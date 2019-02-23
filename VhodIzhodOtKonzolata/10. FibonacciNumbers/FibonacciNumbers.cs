using System;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
       Console.WriteLine("Vuvedi 4islo:");
        int n = int.Parse(Console.ReadLine());
        if (n == 1) Console.WriteLine(0);
        else
        {
            int first = 0;
            int second = 1;
            Console.Write(first + ", ");
            Console.Write(second + ", ");
            int third = 0;
            for (int i = 2; i < n; i++)
            {
                third = first + second;
                Console.Write(third + ", ");
                first = second;
                second = third;
            }
        }
    }
}

