//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceMatrix
{
    class SequenseMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int length = 0;
            int bestLength = 0;
            string bestElement = "asd";
            bool bBreak = false;
            string[,] masiv = new string[n, m];
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1)-1; j++)
                {
                    if (masiv[i,j] == masiv[i,j+1])
                    {
                        length++;
                        if (length>bestLength)
                        {
                            bestLength = length;
                            bestElement = masiv[i, j];
                        }
                    }
                    else
                    {
                        length = 0;
                    }
                }
                length = 0;
            }
            for (int j = 0; j < masiv.GetLength(1); j++)
            {
                for (int i = 0; i < masiv.GetLength(0)-1; i++)
                {
                    if (masiv[i,j] == masiv[i+1, j])
                    {
                        length++;
                        if (length>bestLength)
                        {
                            bestLength = length;
                            bestElement = masiv[i, j];
                        }
                    }
                    else
                        {
                            length = 0;

                        }
                    
                }
                length = 0;
            }
            for (int i = 0; i < masiv.GetLength(0)-1; i++)
            {
                for (int j = 0; j < masiv.GetLength(1) - 1; j++)
                {
                    for (int k = i+1; k < masiv.GetLength(0); k++)
                    {
                        for (int l = j+1; l < masiv.GetLength(1); l++)
                        {
                            if (masiv[i, j] == masiv[k, l])
                            {
                                length++;

                                if (length > bestLength)
                                {
                                    bestLength = length;
                                    bestElement = masiv[k, l];
                                }
                                break;
                            }
                            else
                            {
                                length = 0;
                                bBreak = true;
                                
                            }
                        }
                        if (bBreak)
                        {
                            break;
                        }
                    }
                }
                length = 0;
            }
            Console.WriteLine("The element is {0}", bestElement);
        }
    }
}
