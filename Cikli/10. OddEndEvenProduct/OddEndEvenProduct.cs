using System;
using System.Linq;
/*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
Examples:

numbers	result
2 1 1 6 3	yes
product = 6	
3 10 4 6 5 1	yes
product = 60	
4 3 2 5 2	no
odd_product = 16	
even_product = 15
 */
class OddEndEvenProduct
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        int[] numbers = n.Split(' ').Select(int.Parse).ToArray(); ;
        int productOdd = 1;
        int productEven = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= numbers[i];
            }
            else
            {
                productEven *= numbers[i];
            }
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine(productOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product:{0}",productOdd);
            Console.WriteLine("even_product:{0}", productEven);
        }
    }
}

