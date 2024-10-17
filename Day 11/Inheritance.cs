using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class College : Student
    {
        public string CollegeName { get; set; }

        public override string ToString()
        {

            return $"Name : {Name}, Email : {Email}, college name : {CollegeName}";
        }

    }
    class School : Student
    {
        public string SchoolName { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}, Email : {Email}, college name : {SchoolName}";
        }

    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            var college = new College
            {
                Name = "gatha",
                Email = "gatha@gmail.com",
                CollegeName = "GECB"

            };
            Console.WriteLine(college);
            var school = new School
            {
                Name = "geethu",
                Email = "geethu@gmail.com",
                SchoolName = "GHSS"


            };
            Console.WriteLine(school);


        }
    }
}
