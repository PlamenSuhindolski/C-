/*Write a program that reads from the console a sequence of positive integer numbers.
The sequence ends when empty line is entered.
Calculate and print the sum and average of the elements of the sequence.
Keep the sequence in List<int>.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    class SumAndAverage
    {
        static void Main()
        {
            List<int> elements = new List<int>();
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

            foreach (var element in elements)
            {
                sum += element;
            }
            average = sum / elements.Count();
            Console.WriteLine("the sum is {0} and the average is {1}", sum, average);
        }
    }
}
