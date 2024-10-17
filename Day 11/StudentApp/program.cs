using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stManager = new StudentManagement();

            while(true)
            {
                Console.WriteLine("Welcome to Student Mangement");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.Write("Enter the choice: ");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        var student = GetStudentData();
                        stManager.Add(student);
                        break;
                    case "2":
                        Console.Write("Enter the registartion no:");
                        int registrationNumber = int.Parse(Console.ReadLine());
                        stManager.Search(registrationNumber);
                        break;
                    case "3":
                        var studentUpdate = GetStudentData();
                        stManager.Update(studentUpdate.RegistrationId, studentUpdate.Name, studentUpdate.Class,studentUpdate.Mark);
                        break;
                    case "4":
                        Console.Write("Enter the registartion no:");
                        int numberToDelete = int.Parse(Console.ReadLine());
                        stManager.Delete(numberToDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private static Student GetStudentData()
        {
            var student = new Student();
            

            Console.Write("Enter the registration no:");
            student.RegistrationId = int.Parse(Console.ReadLine());

            Console.Write("Enter the name:");
            student.Name = Console.ReadLine();

            Console.Write("Enter the class: ");
            student.Class = int.Parse(Console.ReadLine());
            var mark = new List<Marks>();
            while (true)
            {
                Console.Write("Enter the subject name or q to exit:");
                string subject = Console.ReadLine();

                if(subject.Trim().ToLower() == "q")
                {
                    break;
                }

                Console.Write("Enter mark obtained:");
                int marksObtained = int.Parse(Console.ReadLine());

                Console.Write("Enter total marks:");
                int totalMark = int.Parse(Console.ReadLine());


                mark.Add(new Marks { Subject = subject, MarksObtained = marksObtained, TotalMark = totalMark });
            }
            student.Mark = mark;
            return student;

        }
    }
}
