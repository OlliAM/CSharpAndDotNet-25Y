using Opgave04.model;

namespace Opgave04;

internal class Program
{
    public static void Main(string[] args)
    {
        Product computer = new("1", "Computer", 10000, "Electronics");
        Product mouse = new("2", "Mouse", 200, "Electronics");
        Product desk = new("3", "Desk", 500, "Furniture");

        Product discountedComputer = computer with { Price = computer.Price * 0.9m };
        Console.WriteLine($"Original price of {computer.Name}: {computer.Price:C}");
        Console.WriteLine($"Discounted price of {discountedComputer.Name}: {discountedComputer.Price:C}");

        var (id, name, price, category) = mouse;
        Console.WriteLine($"Mouse details - Id: {id}, Name: {name}, Price: {price:C}, Category: {category}");
    }
}