/*Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
using System;
using System.Linq;
class BinarySearch
{
    static void Search(int[] arr, int start, int end, int element)
    {
        int middle = start + (end - start) / 2;
        if (element < arr[middle])
        {
            Search(arr, start, middle - 1, element);
        }
        else if (element > arr[middle])
        {
            Search(arr, middle + 1, end, element);
        }
        else
        {
            Console.WriteLine("The index of {0} is {1}", element, middle);
            return;
        }
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int element = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        Search(arr, 0, arr.Length, element);
    }
}

