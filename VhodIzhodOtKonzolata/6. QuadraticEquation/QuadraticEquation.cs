using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Vuvedi koeficienti:\na=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        if(d>=0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1={0}  x2={1}",x1,x2);
        }
        else
        {
            Console.WriteLine("Nqma realni koreni");
        }

    }
}

