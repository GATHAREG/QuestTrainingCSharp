using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
     class StudentManagement
    {
        private List<Student> students = new List<Student>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        public void Add(Student student)
        {
            //check if the student exists
            if (GetStudentByNumber(student.RegistrationId) != null)
            {
                Console.WriteLine("Student  already exists");
                return;
            }
            students.Add(student);
            Console.WriteLine("Student added successfully");

        }
        public void Search(int registrationNumber)
        {
            var student = GetStudentByNumber(registrationNumber);
            Console.WriteLine(student);

        }
        public void Update(int registrationNumber,string name,int classno,List<Marks> Mark) 
        {
            var student = GetStudentByNumber(registrationNumber);
            if(student == null)
            {
                Console.WriteLine("Student is not found");
                return;
            }
            student.RegistrationId = registrationNumber;
            student.Name = name;
            student.Class = classno;
            student.Mark = Mark;
           
            Console.WriteLine("Updated student details");
        }
        public void Delete(int registrationNumber)
        {
            var student = GetStudentByNumber(registrationNumber);
            if(student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            students.Remove(student);
            Console.WriteLine("Sudent deleted successfully");

        }
        private Student GetStudentByNumber(int registrationNumber)
        {
            // check if the student exists
            foreach(var student in students)
            {
                if(student.RegistrationId == registrationNumber)
                {
                    return student;
                }
            }

            return null;
        }

    }
}
