/*Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
 */
using System;
class FindSumInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        int start = 0;
        int end = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            start = i;
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    end = j;
                    for (int k = start; k <= end; k++)
                    {
                        if (k == end)
                        {
                            Console.WriteLine(arr[k]);
                        }
                        else Console.Write(arr[k] + ",");
                    }
                }
            
            }
        }
       
    }
}

