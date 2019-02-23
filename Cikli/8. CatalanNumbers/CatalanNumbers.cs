using System;
using System.Numerics;
/*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845
 */
class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger Factk = 1;
        BigInteger Factn = 1;
        for (int i = 1; i <= 2*n; i++)
        {
            if (i <= n)
            {
                Factk *= i;
            }
            if (2*n - n < i && i <= 2*n)
            {
                Factn *= i;
            }
        }
        BigInteger Fact = Factn / Factk;
        BigInteger Catalan = Fact / (n + 1);
        Console.WriteLine(Catalan);
    }
}

