using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2
{
    class QuickSort2
    {

        static List<int> QuickSort(List<int> arr)
        {
            if (arr.Count<=1)
            {
                return arr;
            }
            int pivot = arr[arr.Count / 2];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < pivot)
                {
                    less.Add(arr[i]);
                }
                else if(arr[i] > pivot)
                {
                    greater.Add(arr[i]);
                }
            }
            return Slivane(QuickSort(less), pivot, QuickSort(greater));
        }

        static List<int> Slivane(List<int> less, int pivot, List<int> greater)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < less.Count; i++)
            {
                result.Add(less[i]);
            }

            result.Add(pivot);

            for (int i = 0; i < greater.Count; i++)
            {
                result.Add(greater[i]);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            List<int> arrayOfIntegers = new List<int>() { 31, 5, 47, -58, 9, 31, 5, 6, 227, 24, -100, -2 };
            List<int> SortiranVid = QuickSort(arrayOfIntegers);
            for (int i = 0; i < SortiranVid.Count; i++)
            {
                Console.WriteLine(SortiranVid[i] + ",");
            }
        }
    }
}
