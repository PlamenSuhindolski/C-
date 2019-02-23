//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFiles
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string path = "file.txt";
            StreamReader file = new StreamReader(path);
            int lineCount = 0;
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                lineCount++;
                if ( lineCount%2 == 1)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
