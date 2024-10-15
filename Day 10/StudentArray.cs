using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class Student
    {
         public string Name;
         public int Mark1;
         public int Mark2;
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        { 

            var s1 = new Student
            {
                Name = "Gatha",
                Mark1 = 80,
                Mark2 = 90
            };
            //object creation of student class
            var s2 = new Student
            {
                Name = "Geethu",
                Mark1 = 90,
                Mark2 = 99
            };
            var s3 = new Student
            {
                Name = "John",
                Mark1 = 100,
                Mark2 = 100
            };
            // Declaring a student array to hold the student details
            
            Student[] students = new Student[5];
            //Assigning the object as elements of student array

                   //  Student[] students = new Student[3] {s1,s2,s3};

             //Assigning the object as elements of student array

            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach(var  student in students)
            {
               // Console.WriteLine($"name:{student.Name}, total mark : {student.Mark1 + student.Mark2}");
               if (student != null)
               {
                   Console.WriteLine($"name:{student.Name}, total mark : {student.Mark1 + student.Mark2}");
                }
            }

            Console.ReadKey();

        }
    }
}
