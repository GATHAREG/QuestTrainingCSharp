using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerWorking
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
        
        public object this[int index]
        {
            get 
            {
                if(index == 0)
                    return Id;
                else if(index == 1) return Name;
                else return null;
            
            }
            set 
            {
                if(index == 0) 
                    Id = Convert.ToInt32(value);
                else if(index == 1)
                    Name = value.ToString();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(1,"gatha");
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);

            student[0] = 2;
            student[1] = "geethu";
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);

        }
    }
}
