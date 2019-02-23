/*Write a program that compares two char arrays lexicographically (letter by letter)
 */
using System;
class CompareCharArrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[] arr1 = new char[n];
        char[] arr2 = new char[n];
        bool equal = true;
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                equal = false;
            }
        }
        Console.WriteLine(equal);
    }
}

