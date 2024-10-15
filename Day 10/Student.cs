// Oops implementaion of class student
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDay1
{
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void TotalMark()
        {
            Console.WriteLine($"Total mark is : {Mark1 + Mark2 + Mark3}");
        }

        public void AverageMark()
        {
            Console.WriteLine($"Average mark is: {(Mark1 + Mark2 + Mark3) / 3}");

        }
    }
    internal class Program
    {
        /* class Student
         {
             public string Name;
             public void DisplayName()
             {
                 Console.WriteLine(Name.ToUpper());
             }
         } */
        /* class Employee
         {
             public string FirstName;
             public string LastName;
             public int Salary;

             public void TotalSalary()
             {
                 Console.WriteLine($"Total slary is :{Salary*12}");
             }
         } */

        
        static void Main(string[] args)
        {
            /*
            Student s= new Student();
            s.Name = " John";
            s.DisplayName();

            Student s2 = new Student();
            s.Name = "Jane";
            s2.DisplayName(); */

          /*
            Employee employee1 = new Employee();
            employee1.FirstName = "Gatha";
            employee1.LastName = " Reghu";
            employee1.Salary = 10_000;

            Employee employee2 = new Employee();
            employee2.FirstName = "John";
            employee2.LastName = "Doe";
            employee2.Salary = 15_000;

            employee1.TotalSalary();
            employee2.TotalSalary(); */

            Student student1 = new Student();
            student1.Name  = "Gatha";
            student1.Mark1 = 80;
            student1.Mark2 = 90;
            student1.Mark3 = 95;

            student1.TotalMark();
            student1.AverageMark();

            Student student2 = new Student();
            student2.Name  = "Geethu";
            student2.Mark1 = 89;
            student2.Mark2 = 98;
            student2.Mark3 = 99;

            student2.TotalMark();
            student2.AverageMark();
        }
    }
}
