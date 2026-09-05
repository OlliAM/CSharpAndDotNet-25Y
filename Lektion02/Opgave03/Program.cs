using Opgave03.model;

namespace Opgave03;

class Program
{
    static void Main(string[] args)
    {
        const string text = "Dette er et leetspeak eksempel";
        Console.WriteLine(text.ToLeetSpeak());
    }
}

