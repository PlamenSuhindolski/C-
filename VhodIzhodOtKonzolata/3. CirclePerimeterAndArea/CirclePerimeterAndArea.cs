using System;
/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/
class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi radiusa:");
        double r = double.Parse(Console.ReadLine());
        double p = 2 * Math.PI * r;
        double s = Math.PI * r * r;
        Console.WriteLine("Perimeturut e:{0:0.00}",p);
        Console.WriteLine("Liceto e:{0:0.00}",s);
    }
}

