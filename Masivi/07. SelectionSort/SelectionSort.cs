/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }

                }
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                
            }
            for (int i = 0; i < n; i++)
            {
                 Console.WriteLine(arr[i]);
            }
        }
    }
}
