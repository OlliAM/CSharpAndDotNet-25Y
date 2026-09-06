using System.Runtime.CompilerServices;
using static Lektion03Opgave03.StarWarsRepository;

namespace Lektion03Opgave03;

class Lektion03Opgave03Main
{
    static async Task Main(string[] args)
    {
        var starWarsRepo = new StarWarsRepository();
        
        await HentKarakter(starWarsRepo, "Henter karakter 1", 1, "\nKarakter 1: ");

        await HentKarakter(starWarsRepo, "Henter karakter 2", 2, "\nKarakter 2: ");

        await HentKarakter(starWarsRepo, "Henter karakter 5", 5, "\nKarakter 5: ");
    }

    private static async Task HentKarakter(StarWarsRepository starWarsRepo, string henterKarakter, int id, string karakter)
    {
        Console.WriteLine(henterKarakter);
        var char1 = starWarsRepo.GetUserByIdAsync(id);
        SimulateWait(char1);
        Console.WriteLine(karakter + await char1);
    }

    static void SimulateWait(Task<string> task)
    {
        while (!task.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}
