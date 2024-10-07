using Day5Namespace.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MathUtilities.Add(1, 2);
            MathUtilities.Sub(4, 2);
            StringUtilities.ToUpperCase("hi");
            StringUtilities.ToLowerCase("HI"); */

            //DateTime


            DateTime  dt = DateTime.Now;
            Console.WriteLine(dt);

            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month :{dt.Month}");
            Console.WriteLine($"Year : {dt.Year}");
            Console.WriteLine($"Hour : {dt.Hour}");
            Console.WriteLine($"Minute : {dt.Minute}");
            Console.WriteLine($"Second : {dt.Second}");
            Console.WriteLine($"MilliSecond :{dt.Millisecond}");

            //Formatting date and time

            Console.WriteLine("---------");
            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy"));

            //Constructing Date and Time 
            var myDt = new DateTime(2024, 10, 07, 10, 50, 49);
            Console.WriteLine(myDt);
            //exercise to calculate the age of a person

            //display the age of person
            Console.Write("Enter Your Date of birth (DD/MM/YYYY):");
            DateTime Date = DateTime.Parse(Console.ReadLine());
            DateTime dtt = DateTime.Now;
            
            int age = dtt.Year- Date.Year;

            //calculating age
            Console.WriteLine($"Your age is :{age}");

           
        }
    }
}
