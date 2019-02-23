//Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByIncreasing
{
    class Sorting
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            int number = 0;
            string input = Console.ReadLine();
            int min;
            while (!string.IsNullOrEmpty(input))
            {
                number = int.Parse(input);
                elements.Add(number);
                input = Console.ReadLine();
            }
            for (int i = 0; i < elements.Count(); i++)
            {
                min = i;
                for (int j = i+1; j < elements.Count(); j++)
                {
                    if (elements[j]<elements[min])
                    {
                        min = j;
                    }
                   
                }
                int temp = elements[i];
                elements[i] = elements[min];
                elements[min] = temp;
                
            }

            foreach (var element in elements)
            {
                Console.Write(element + ",");
            }
        }
    }
}
