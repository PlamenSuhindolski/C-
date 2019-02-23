using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vuvedi 2 4isla:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for(int i = a; i <= b; i++)
        {
            if(i % 5 ==0)
            {
                count++;
                Console.WriteLine(i);  
            }
        }
        Console.WriteLine("Broi 4isla:{0}", count);  
        }
    }


