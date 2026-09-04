using System.Globalization;
using Opgave02.model;

namespace Opgave02;

class Program
{
    static void Main(string[] args)
    {
        var products = SeedData.Products;
        var customers = SeedData.Customers;
        // 1. Find alle produkter i kategorien Category.Elektronik, som er på lager (StockCount > 0)

        var electronicsInStock = products
            .Where(e => e is { Category: Category.Elektronik, StockCount: > 0 });
        
        // 2. Udskriv navn og pris for disse produkter, sorteret efter pris i faldende rækkefølge (dyreste først)

        Console.WriteLine("Elektronik produkter på lager: \n");
        electronicsInStock
            .OrderByDescending(e => e.Price)
            .ToList()
            .ForEach(Console.WriteLine);

        // 3. Find alle kunder fra byen "Aarhus" og udskriv deres navne

        Console.WriteLine("\nKunder fra Aarhus:\n");
        customers
            .Where(c => c.City == "Aarhus")
            .ToList()
            .ForEach(Console.WriteLine);
        
        // 4. Find de 3 mest solgte produkter målt på samlet solgt antal.

        Console.WriteLine("\n3 Mest solgte produkter: \n");
        customers
            .SelectMany(c => c.Orders)
            .SelectMany(o => o.Items)
            .GroupBy(i => i.Product)
            .OrderByDescending(g => g.Sum(i => i.Quantity))
            .Take(3).ToList()
            .ForEach(g => Console.WriteLine($"{g.Key.Name}: {g.Sum(i => i.Quantity)} solgt"));
        
        // 5. Lav en opgørelse over alle kunder og deres samlede købsbeløb i shoppen.
        
        Console.WriteLine("\nKundernes samlede købsbeløb i shoppen:\n");
        customers
            .Select(c => new
            {
                CustomerName = c.Name,
                OrderCount = c.Orders.Count,
                TotalSpent = c.Orders
                    .SelectMany(o => o.Items)
                    .Select(i => i.Quantity * i.Product.Price)
                    .Sum()
            })
            .OrderByDescending(c => c.TotalSpent)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}
