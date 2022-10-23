using System.Numerics;
using System;
class Program
{
    static void Main(string[] args)
    {
        int len = GetLen();
        while (len < 0)
        {
            len = GetLen();
        }

        IterateFibonaci(len);
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

    public static void IterateFibonaci(int len)
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
}