using System;
/*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
Examples:

a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5
 */
class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Vuvedi 2 stoinosti:\na=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        double n = a;
        if(a>b)
        {
            a = b;
            b = n;

        }
        Console.Write("a={0} b={1}",a,b);
    }
}

