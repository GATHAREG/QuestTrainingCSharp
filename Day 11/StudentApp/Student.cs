using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        public int RegistrationId;
        public string Name;
        public int Class;
       //  public Marks mark = new Marks();
        public List<Marks> Mark;





        public override string ToString()
        {
            var result = $"Registration id :{RegistrationId}, Name :{Name}, class: {Class}, Mark Details:";

             foreach(var mark in Mark)
             {
                result += $"\n  Subject: {mark.Subject}, Marks Obtained: {mark.MarksObtained}, Total Marks: {mark.TotalMark}";

            };
            return result ;
        }

    }
}
