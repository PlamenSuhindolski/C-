/*Write a program that finds the maximal increasing sequence in an array.
Example:

input	result
3, 2, 3, 4, 2, 2, 4	2, 3, 4
 */
using System;
class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int BestLength = 1;
        int Length = 1;
        int index = 0;
        int CurrentIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr.Length == 1)
        {
            BestLength = Length;
            index = 0;
            return;
        }
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i-1])
            {
                Length++; 
            }
            else
            {
                Length = 1;
                CurrentIndex = i;
              

            }
            if(Length >= BestLength)
            {
                BestLength = Length;
                index = i;
                
            }
        }
        for (int i = index - BestLength + 1; i <= index; i++)
        {
           if (i == index)
           {
               Console.WriteLine(arr[i]);
           }
           else Console.Write(arr[i] + ",");
            
        }
     
    }
}

