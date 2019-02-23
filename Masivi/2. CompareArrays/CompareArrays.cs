/*Write a program that reads two integer arrays from the console and compares them element by element.
 */
using System;
class CompareArrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        bool equal = true;
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr2.Length; i++)
        {
             arr2[i] = int.Parse(Console.ReadLine());
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

