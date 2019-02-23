using System;
class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi 4islata:");
        string[] n = Console.ReadLine().Split();
        double a = Convert.ToDouble(n[0]);
        double b = Convert.ToDouble(n[1]);
        double c = Convert.ToDouble(n[2]);
        double d = Convert.ToDouble(n[3]);
        double e = Convert.ToDouble(n[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("Sumata e:{0}",sum);
    }
}

