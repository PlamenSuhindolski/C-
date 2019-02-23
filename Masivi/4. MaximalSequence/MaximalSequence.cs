/*Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 */
using System;
class MaximalSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int BestElement = 0;
        int BestLength = 0;
        int Element = arr[0];
        int Length = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        if(arr.Length == 1)
        {
            BestElement = Element;
            BestLength = Length;
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == Element)
            {
                Length++;
            }
            else
            {
                Element = arr[i];
                Length = 1;
            }
            if (Length>=BestLength)
            {
                BestLength = Length;
                BestElement = Element;
            }
        }
        for (int i = 0; i < BestLength-1; i++)
        {
            Console.Write(BestElement + ",");
            if (i == BestLength-2)
            {
                Console.Write(BestElement);
            }
        }
        Console.WriteLine();

    }
}

