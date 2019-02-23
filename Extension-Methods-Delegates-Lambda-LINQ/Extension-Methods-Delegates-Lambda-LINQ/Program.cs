using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ.Extensions
{
    class Program
    {
       public static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder(5, 10);
            test.Append('1',10);
            Console.WriteLine(test.Substring(5,5));
            List<int> numbers = new List<int>{ 5, 21, 4, 7, 3 };
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Product());
            List<Student> students = new List<Student> { new Student("Pesho", "Ivanov", 23), new Student("Ivan", "Peshov", 24), new Student("Georgi", "Georgiev", 25), new Student("Dragan", "Peshev", 17) };
           List<Student> newStudents = FirstBeforeLast(students);
           Console.WriteLine(newStudents.First().firstName);

           var OrderByAndThenBy = students.OrderBy((student) => student.firstName).ThenBy((student) => student.lastName);
           OrderByAndThenBy.ToList();
           foreach (var student in OrderByAndThenBy)
           {
               Console.WriteLine(student.firstName + student.lastName + student.age);
           }
        }

       public static List<Student> FirstBeforeLast(List<Student> students)
       {
           var newStudents = from student in students
                             where (student.firstName[0] < student.lastName[0])
                             select student;
           return newStudents.ToList();
       }

       public static List<Student> AgeFrom18To24(List<Student> students)
       {
           var newStudents = from student in students
                             where student.age > 18 && student.age < 24
                             select student;
           return newStudents.ToList();
       }




    }
}
