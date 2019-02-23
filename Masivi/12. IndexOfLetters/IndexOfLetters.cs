/*Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            string word = Console.ReadLine().ToLower();
            foreach (char letter in word)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine("{0}->{1}",letter,i);
                    }
                }
            }
        }
    }
}
