using System;
using System.Numerics;
/*In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960
 */
class CalculateFactorial
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        BigInteger Factk = 1;
        BigInteger Factn = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i<=k)
	        {
                Factk *= i;
            }
            if (n-k<i && i<=n )
            {
                Factn *= i;
            }
        }
        BigInteger Fact = Factn / Factk;
        Console.WriteLine(Fact);
    }
}

