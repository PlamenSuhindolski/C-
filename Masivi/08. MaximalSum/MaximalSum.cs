/*Write a program that finds the sequence of maximal sum in given array.
Example:

input	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
 */
using System;
class MaximalSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int BestSum = 0;
        int start = 0;    
        int end = 0;
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
            if(sum > BestSum)
            {
                BestSum = sum;
                end = i;
               
            }
            if (sum < arr[i])
            {
                sum = arr[i];
                start = i;
            }
        }
        for (int i = start; i <= end; i++)
        {
             Console.WriteLine(arr[i]);
        }
    }
}

