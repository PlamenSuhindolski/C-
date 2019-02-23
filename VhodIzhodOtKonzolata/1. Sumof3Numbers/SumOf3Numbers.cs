using System;
class SumOf3Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Vuvedi 3 4isla:\na=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("Sumata im e: {0}",sum);

    }
}

