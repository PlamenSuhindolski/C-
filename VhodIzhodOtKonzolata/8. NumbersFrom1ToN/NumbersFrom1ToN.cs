using System;
class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi 4islo:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}

