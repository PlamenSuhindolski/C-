//The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
//Write a program to find the majorant of given array (if exists).
//Example:
//{2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorantOfArray
{
    class MajorantOfArray
    {
        static void Main()
        {
            int[] elements = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Dictionary<int,int> occurances = new Dictionary<int,int>();
            Stack<int> stack = new Stack<int>();
            foreach (var element in elements)
            {
                if (stack.Count == 0 || stack.Peek() == element)
                {
                    stack.Push(element);
                    if (!occurances.ContainsKey(element))
                    {
                        occurances.Add(element, 1);
                        continue;
                    }
                    occurances[element]++;
                }
                else
                {
                    if (!occurances.ContainsKey(element))
                    {
                        occurances.Add(element, 1);
                    }
                    else
                    {
                        occurances[element]++;
                    } 
                    stack.Push(element);
                }
                
            }
            if (occurances.Values.Max() >= (elements.Count()) / 2 + 1)
            {
                Console.WriteLine(occurances.FirstOrDefault(x => x.Value == occurances.Values.Max()).Key);
            }
        
        }
    }
}
