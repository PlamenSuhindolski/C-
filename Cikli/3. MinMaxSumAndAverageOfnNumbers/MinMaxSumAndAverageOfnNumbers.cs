using System;
using System.Linq;
/*write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
Example 1:

input	output
3 
2 
5 
1	min = 1 
max = 5 
sum = 8 
avg = 2.67
Example 2:

input	output
2 
-1 
4	min = -1 
max = 4 
sum = 3 
avg = 1.50
 */
class MinMaxSumAndAverageOfnNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi 4isla:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0; 
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Array.Sort(numbers);
        decimal avg = (decimal)sum / n;
        Console.WriteLine("min = {0}",numbers.First());
        Console.WriteLine("max = {0}", numbers.Last());
        Console.WriteLine("avg = {0:0.00}", avg);


    }
}

