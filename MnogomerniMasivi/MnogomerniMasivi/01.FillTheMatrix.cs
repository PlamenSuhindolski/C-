//Write a program that fills and prints a matrix of size (n, n) as shown below:
 /*   1	5	9	13    
    2	6	10	14
    3	7	11	15
    4	8	12	16 
  * 
 1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
  * 
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
  * 
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerniMasivi
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            /*    int n = int.Parse(Console.ReadLine());
                int[,] masiv = new int[n, n];
                for (int i = 0; i < masiv.GetLength(0); i++)
                {
                    for (int j = 0; j < masiv.GetLength(1); j++)
                    {
                        masiv[i, j] = j*n + 1 + i;
                    }
                }
                for (int i = 0; i < masiv.GetLength(0); i++)
                {
                    for (int j = 0; j < masiv.GetLength(1); j++)
                    {
                        Console.Write("{0} ", masiv[i,j]);
                    }
                    Console.WriteLine();
                } */

            /* int n = int.Parse(Console.ReadLine());
             int[,] masiv = new int[n, n];
             for (int i = 0; i < masiv.GetLength(0); i++)
             {
                 for (int j = 0; j < masiv.GetLength(1); j++)
                 {
                     if (j % 2 == 0)
                     {
                         masiv[i, j] = j * n + 1 + i;
                     }
                     else
                     {
                         masiv[i, j] = j * n + n - i;
                     }
                 }
             }
             for (int i = 0; i < masiv.GetLength(0); i++)
             {
                 for (int j = 0; j < masiv.GetLength(1); j++)
                 {
                     Console.Write("{0} ", masiv[i, j]);
                 }
                 Console.WriteLine();
             } */

            int n = int.Parse(Console.ReadLine());
            int[,] masiv = new int[n, n];
            int counter = 1;
            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    masiv[row + col, col] = counter++;
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    masiv[row, col + row] = counter++;
                }
            }
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    Console.Write("{0} ", masiv[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
