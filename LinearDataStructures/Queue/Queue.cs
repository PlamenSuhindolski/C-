/*We are given the following sequence:
S1 = N;
S2 = S1 + 1;
s3 = 2*s1 + 1;
s4 = s1 + 2;
s5 = s2 + 1;
s6 = 2*s2 + 1;
s7 = s2 + 2;
...
Using the Queue<T> class write a program to print its first 50 members for given N.
Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Queue
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int current = queue.Dequeue();
            var actions = new Action[]
            {
                 () =>
                 {
                     queue.Enqueue(current + 2);
                     current = queue.Dequeue();
                     Console.Write((current + ", "));
                 },
                 () => queue.Enqueue(current + 1),
                 () => queue.Enqueue(2 * current + 1)

            };

            for (int i = 1; i < 51; i++)
            {
                actions[i % 3]();
            }


        }
    }
}
