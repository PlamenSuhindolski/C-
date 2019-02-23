using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch2
{
    class BinarySearch2
    {
        static void BinarySearch(int[] arr, int element)
         {
             int start = 0;
             int end = arr.Length - 1;
             
             while (start<=end)
             {
                 int mid = (start + end) / 2;
                 if (element == arr[mid])
                 {
                     Console.WriteLine("poziciqta mu e {0}", mid);
                     return;
                 }
                 else if (element < arr[mid])
                 {
                     end = arr[mid];
                 }
                 else if (element>arr[mid])
                 {
                     start = arr[mid];
                 }
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
            Array.Sort(arr);
            int element = int.Parse(Console.ReadLine());
            BinarySearch(arr, element);
        }
    }
}
