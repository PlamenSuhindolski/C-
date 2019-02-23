using System;
class SumOfnNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi 4islo:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine("Sumata im e:{0}",sum);
    }
}

