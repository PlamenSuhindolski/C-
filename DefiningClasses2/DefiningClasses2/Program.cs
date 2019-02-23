using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    using System;
    class Program
    {
        static void Main()
        {
            Point3D p1 = new Point3D(5.4, 6.2, 3);
            Point3D p2 = new Point3D(7.9, 2.1, 5.9);
            Point3D p3 = new Point3D(23.4, 3, 5);
            Point3D p4 = new Point3D(7, 15.5, 57.7);
            Point3D p5 = new Point3D(-5, 20.5, 43.4);
            Path path = new Path();
            path.AddPoint(p1);
            path.AddPoint(p2);
            path.AddPoint(p3);
            path.AddPoint(p4);
            for (int i = 0; i <4; i++)
            {
                Console.WriteLine(path[i]);
            }
            var distance = CalculateDistance.calculateDistance(p1,p2);
            Console.WriteLine(distance);
            PathStorage.SavePaths(path, "PointsFromPath.txt");
            /*Path pathFromFile = PathStorage.LoadPath("PointsFromPath.txt");
            for (int i = 0; i < 4 ; i++)
            {
                Console.WriteLine(pathFromFile[i]);
            }*/
            GenericList<Point3D> listOfPoints = new GenericList<Point3D>(5);
            listOfPoints.AddElement(p1);
            listOfPoints.AddElement(p2);
            listOfPoints.AddElement(p3);
            listOfPoints.AddElement(p4);
            listOfPoints.AddElement(p5);
            listOfPoints.RemoveElement(3);
            listOfPoints.InsertAtPosition(3,p3);
            Console.WriteLine(listOfPoints[3]);
            Console.WriteLine(listOfPoints.IndexOf(p3));
        }
    }
}
