using System;
/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
 */
class CalculateFactorials
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        int Factn = 1;
        int Factk = 1;
        for (int i = 1; i <= n; i++)
        {
            Factn *= i;
            if (i <= k)
            {
                Factk *= i;
            }
        }
        int Fact = Factn / Factk;
        Console.WriteLine(Fact);
    }
}

