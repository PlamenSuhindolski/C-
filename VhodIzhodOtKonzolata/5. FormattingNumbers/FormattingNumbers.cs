using System;
/*
 Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 */
class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Vuvedi po 3 4isla:\na=");
        int a = int.Parse(Console.ReadLine());
        int a1 = int.Parse(Console.ReadLine());
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("b=");
        float b = float.Parse(Console.ReadLine());
        float b1 = float.Parse(Console.ReadLine());
        float b2 = float.Parse(Console.ReadLine());
        Console.Write("c=");
        float c = float.Parse(Console.ReadLine());
        float c1 = float.Parse(Console.ReadLine());
        float c2 = float.Parse(Console.ReadLine());
        Console.Write("{0,1:X} ",a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("   {0,-10 : 0.00}", b.ToString("0.00").PadRight(10, ' '));
        Console.WriteLine("   {0,10 : 0.000}", c.ToString("0.000").PadLeft(10, ' '));
        Console.Write("{0,1:X} ", a1);
        Console.Write(Convert.ToString(a1, 2).PadLeft(10, '0'));
        Console.Write("   {0,-10 : 0.00}", b1.ToString("0.00").PadRight(10, ' '));
        Console.WriteLine("   {0,10 : 0.000}", c1.ToString("0.000").PadLeft(10, ' '));
        Console.Write("{0,1:X} ", a2);
        Console.Write(Convert.ToString(a2, 2).PadLeft(10, '0'));
        Console.Write("   {0,-10 : 0.00}", b2.ToString("0.00").PadRight(10, ' '));
        Console.WriteLine("   {0,10 : 0.000}", c2.ToString("0.000").PadLeft(10, ' '));

    }
}

