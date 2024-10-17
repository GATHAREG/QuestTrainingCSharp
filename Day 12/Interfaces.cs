using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    interface IStudent
    {
        string Name { get; }

        void Display();
    }
    class School : IStudent
    {
        public string Name { get; set; }

        public const string SchoolName = "ABC";
        public void Display() 
        {
            Console.WriteLine($"name :{Name}, school :{SchoolName}");
        }
    }
    class College : IStudent
    {
        public string Name { get; set; }

        public const string CollegeName = "gecb";
        public void Display()
        {
            Console.WriteLine($"name :{Name}, school :{CollegeName}");
        }
    }
    internal class Program
    {



        static void Main(string[] args)
        {
            var students = new List<IStudent>
            {
                new School{Name = "gatha"},
                new School{Name = "geethu"},
                new College{Name = "Manu"}
            };

            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
    
}
