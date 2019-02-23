//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] masiv = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    masiv[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            int maxSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int i = 0; i < masiv.GetLength(0)-2; i++)
            {
                for (int j = 0; j < masiv.GetLength(1)-2; j++)
                {
                    sum = masiv[i, j] + masiv[i, j + 1] + masiv[i, j + 2] +
                          masiv[i + 1, j] + masiv[i + 1, j + 1] + masiv[i + 1, j + 2] +
                          masiv[i + 2, j] + masiv[i + 2, j + 1] + masiv[i + 2, j + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            for (int i = bestRow; i < bestRow +3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                {
                    Console.Write("{0} ", masiv[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
