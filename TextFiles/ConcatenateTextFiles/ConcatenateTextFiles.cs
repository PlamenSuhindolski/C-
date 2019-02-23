//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string path1 = "file1.txt";
            string path2 = "file2.txt";
            StreamReader file1 = new StreamReader(path1);
            StreamReader file2 = new StreamReader(path2);
            
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            StringBuilder NomeriraniRedove = new StringBuilder();
            int nomer = 0;
            while (!file1.EndOfStream)
            {
                string line = file1.ReadLine();
                
                list1.Add(line);
            }
            while (!file2.EndOfStream)
            {
                string line = file2.ReadLine();
                list2.Add(line);

            }
            list1.AddRange(list2) ;

            using (StreamWriter result = new StreamWriter("result.txt", true))
            {
                
                foreach (var row in list1)
                {
                    NomeriraniRedove.AppendLine(nomer + "." + row);
                    nomer++;
                    result.WriteLine( NomeriraniRedove);
                }
            }
        }
    }
}
