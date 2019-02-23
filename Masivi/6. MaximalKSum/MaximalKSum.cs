/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */
using System;
using System.Linq;
class MaximalKSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int Sum = 0;
        int maxSum = 0;
        int index = 0;
        int bestindex = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr.Length == 1)
        {
            Sum = arr[0];
            return;
        }
        //Array.Sort(arr);
       // for (int i = n-k; i < n; i++)
       // {
       //     Sum += arr[i];
       // }
       // Console.WriteLine(Sum);
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int j = i;j <i + k; j++)
            {
                           Sum +=arr[j];
            }
            index = i;
            if (Sum>maxSum)
            {
                maxSum = Sum;
                bestindex = index;

            }
            
                Sum = 0;
            

        }
        for (int i = bestindex; i <= bestindex+k-1; i++)
        {
            Console.Write(arr[i] + ",");
        }
    }
}

