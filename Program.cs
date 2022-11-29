using System.Numerics;

namespace FibonacciCalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert the quantity of numbers to calculate");
        int len = GetLen();
        while (len < 0)
        {
            len = GetLen();
        }

        Console.WriteLine("In Recursion");
        IterateFibonacciInRecursion(len);
        Console.WriteLine("");
        Console.WriteLine("In Loop");
        IterateFibonacciInLoop(len);
    }

    private static int GetLen()
    {
        string? len = "";
        int result = 0;
        bool success = false;

        len = Console.ReadLine();
        success = int.TryParse(len, out result);

        if (!success)
        {
            Console.WriteLine($"Attempted conversion of '{len ?? "<null>"}' failed.");
        }
        else if (result > 250)
        {
            Console.WriteLine("Please insert a number bellow 250");
        }
        else
        {
            return result;
        }

        return -1;
    }

    public static void IterateFibonacciInLoop(int len)
    {
        for (int i = 0; i < len; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a;
    }

    public static void IterateFibonacciInRecursion(int len)
    {
        RecursiveMethod(0, 1, 1, new BigInteger(len));
    }

    public static void RecursiveMethod(BigInteger a, BigInteger b, BigInteger counter, BigInteger number)
    {
        Console.Write(a + " ");
        if (counter < number) RecursiveMethod(b, a + b, counter + 1, number);
    }
}