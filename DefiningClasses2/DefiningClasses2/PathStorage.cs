
using System.Threading.Tasks;

namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
   public static class PathStorage
    {
       private static readonly char[] Separators = new char[] { ',', ' ', '[', ']', ';' };

       public static Path LoadPath(string file)
       {
           Path path3D = new Path();
           string[] pointsFromText = File.ReadAllText(file).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

           for (int i = 0; i < pointsFromText.Length; i++)
           {
               string[] coordinates = pointsFromText[i].Split(Separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

               path3D.AddPoint(new Point3D(double.Parse(coordinates[1]), double.Parse(coordinates[3]), double.Parse(coordinates[5])));
           }

           return path3D;
       }

       public static void SavePaths(Path points, string filePath)
       {
           
           File.WriteAllText(filePath, points.ToString());
       }
    }
}
