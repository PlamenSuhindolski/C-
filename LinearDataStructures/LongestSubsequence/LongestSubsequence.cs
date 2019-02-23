//Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubsequence
{
    class LongestSubsequence
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            List<int> result = new List<int>();
            int sum = 0;
            int average = 0;
            int number = 0;
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                number = int.Parse(input);
                elements.Add(number);
                input = Console.ReadLine();
            }
            int currentIndex = 0;
            int bestIndex = 0;
            int count = 0;
            int bestCount = 0;
            for (int i = 0; i < elements.Count(); i++)
            {
                currentIndex = i;
                count = 0;
                for (int j = i+1; j < elements.Count(); j++)
                {
                    if (elements[j]==elements[i])
                    {
                        count++;
                    }
                    if (bestCount<count)
                    {
                        bestCount = count;
                        bestIndex = currentIndex;
                    }
                }
            }
            for (int i = 0; i < bestCount +1; i++)
            {
                result.Add(elements[bestIndex]);
            }
            for (int i = 0; i < result.Count(); i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
