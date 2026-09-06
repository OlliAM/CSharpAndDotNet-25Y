using System.Net.Http.Json;

namespace Lektion03Opgave04;

class Program
{
    private static HttpClient _client = new();
    
    static async Task Main(string[] args)
    {
        var catFact = await FetchCatFactAsync();

        if (catFact != null)
        {
            Console.WriteLine(catFact.Fact);
        }
    }

    static async Task<CatFactDto?> FetchCatFactAsync()
    {
        using HttpClient client = new HttpClient();

        try
        {
            return await client.GetFromJsonAsync<CatFactDto>(
                "https://catfact.ninja/fact");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP error: {ex.Message}");
            return null;
        }
    }
}

public record CatFactDto(string Fact, int Length);