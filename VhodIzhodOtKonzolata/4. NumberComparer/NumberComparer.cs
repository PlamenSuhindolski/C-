using System;
/*
 Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */
class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Greater: ");
        Console.WriteLine(a > b ? a : b);
    }
}

