/*Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedi masiva");
            int[] masiv = new int[n];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());   
            }
            int match = 1;
            int bestmatch = 0;
            int index = 0;
            int bestindex = 0;
            //int bestelement = 1;
            //int element = masiv[0];
           /* if(masiv.Length == 1)
            {
                bestelement = element;
                bestmatch = match;
                return;
            }*/
            for (int i = 1; i < masiv.Length; i++)
            {
                if (masiv[i-1] < masiv[i])
                {
                    match++;
                    index = i;
                }
                else
                {
                    match = 1;
                }
                if (match>bestmatch)
                {
                    bestmatch = match;
                    bestindex = index;
                }
            }
            for (int i = bestindex-bestmatch+1; i <= bestindex; i++)
            {
                Console.WriteLine(masiv[i]);
            }
        }   
       }
    }
