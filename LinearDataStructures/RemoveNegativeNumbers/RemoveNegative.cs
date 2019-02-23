//Write a program that removes from given sequence all negative numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeNumbers
{
    class RemoveNegative
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            int number = 0;
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                number = int.Parse(input);
                elements.Add(number);
                input = Console.ReadLine();
            }
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i]<0)
                {
                    elements.RemoveAt(i);
                }
            }
            for (int i = 0; i < elements.Count(); i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
