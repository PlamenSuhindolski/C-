/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */
using System;
class PrimeNumbers
{
    static void Main(string[] args)
    {
        bool[] num = new bool[10000000];
        int p = 2;
        num[0] = false;
        num[1] = false;
        for (int i = 2; i < 10000000; i++)
        {
            num[i] = true;
        }
        for (int i = 2; i < 10000000; i++)
        {
            for (int j = i + i; j < 10000000; j = j + i)
            {
                num[j] = false;
            }

        }
       int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (num[i] == true) Console.Write(i + " ");
        }
    }
}

