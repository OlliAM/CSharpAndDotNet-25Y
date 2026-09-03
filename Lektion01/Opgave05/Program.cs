using Opgave05.model;

namespace Opgave05;

internal class Program
{
    public static void Main(string[] args)
    {
        var c1 = new GeoPointClass(56.15, 10.20);
        var c2 = new GeoPointClass(56.15, 10.20);
        
        var r1 = new GeoPointRecord(56.15, 10.20);
        var r2 = new GeoPointRecord(56.15, 10.20);
        
        Console.WriteLine("c1 == c2: " + (c1 == c2));
        Console.WriteLine("r1 == r2: " + (r1 == r2));
        
        
        
        
        
        
        
        
        
        
        //c1 == c2 giver false, fordi klasser sammenligner på reference i hukommelsen, mens r1 == r2 giver true, fordi
        //de sammenligner på property-værdier
        
        Console.WriteLine("c1:\n" + c1);
        Console.WriteLine("r1:\n" + r1);
        
    }
}