/*Write a program that finds the most frequent number in an array.
Example:

input	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
 */
using System;
class FrequentNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int count = 1;
        int BestCount = 1;
        int BestNumber = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n-1; i++)
        {
            for (int j = i+1 ; j < n; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }
                if (count > BestCount)
                {
                    BestCount = count;
                    BestNumber = arr[i];
                }
            }
            count = 0;
        }
        Console.WriteLine("{0}({1}times)",BestNumber,BestCount);
    }
}

