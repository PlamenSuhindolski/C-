using System;
/*Write a program that finds the biggest of three numbers.
Examples:

a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
0	-2.5	5	5
-0.1	-0.5	-1.1	-0.1
 */
class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("vuvedi 3 4isla:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if(a>b && a>c)
        {
            Console.WriteLine(a);
        }
        else if(b>a && b>c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

