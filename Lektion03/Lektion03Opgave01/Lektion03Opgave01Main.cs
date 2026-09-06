namespace Lektion03Opgave01;

public delegate double MathOperation(double x, double y);

class Lektion03Opgave01Main
{
    static void Main(string[] args)
    {
        ExecuteAndPrint(2,5, Add);
        ExecuteAndPrint(2,5, Subtract);
        ExecuteAndPrint(2,5, Multiply);
        
        ExecuteAndPrint(2, 5, 
            (x, y) => x / y);
        
        ExecuteAndPrint(2, 5, Math.Pow);
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static void ExecuteAndPrint(double a, double b, MathOperation operation)
    {
        Console.WriteLine(operation(a,b));
    }
}