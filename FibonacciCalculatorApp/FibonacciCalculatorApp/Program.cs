using System.Numerics;
using System;
using System.Diagnostics.Metrics;

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

        IterateFibonaciInRecursion(len);
        //IterateFibonaciInLoop(len);
    }

    private static int GetLen()
    {
        string len = "";
        int result = 0;
        bool success = false;
        len = Console.ReadLine();
        success = int.TryParse(len, out result);

        if (!success)
        {
            Console.WriteLine($"Attempted conversion of '{len ?? "<null>"}' failed.");
        }else if (result > 250)
        {
            Console.WriteLine("Please insert a number bellow 250");
        }else
        {
            return result;
        }
        return -1;
    }

    public static void IterateFibonaciInLoop(int len)
    {
        BigInteger a = 0, b = 1, c = 0;

        for (int i = 2; i < len; i++)
        {
            c = a + b;
            Console.Write(c+ " ");
            a= b;
            b= c;   
        }
    }

    public static void IterateFibonaciInRecursion(int len)
    {
        RecursiveMethod(0, 1, 1, new BigInteger(len));
    }

    public static void RecursiveMethod(BigInteger a, BigInteger b, BigInteger counter, BigInteger number)
    {
        Console.Write(a + " ");
        if (counter < number) RecursiveMethod(b, a + b, counter + 1, number);

    }
}