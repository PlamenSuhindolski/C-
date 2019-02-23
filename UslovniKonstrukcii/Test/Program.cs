using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi dolna granica");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi gorna granica");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <=n; i++)
            {
                bool prime = true;
                int devider = 2;
                double maxDevider = Math.Sqrt(i);
                while (devider<= maxDevider)
                {
                    if (i%devider == 0)
                    {
                        prime = false;
                        break;
                    }
                    devider++;
                }
                if (prime)
                {
                    Console.Write("{0}", i + " ");  
                }
                
            }

        }
    }
}
