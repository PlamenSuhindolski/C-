//Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurs
{
    class NumberOfOccurs
    {
        static void Main(string[] args)
        {
            int[] elements = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int count = 0;
            int[] result = new int[1001];

            foreach (var element in elements)
	        {
                result[element]++;
	        }
            for (int i = 0; i < result.Count(); i++)
            {
                if (result[i] != 0)
                {
                    Console.WriteLine("{0} - {1} times", i, result[i]);
                }
            }
        }
    }
 }