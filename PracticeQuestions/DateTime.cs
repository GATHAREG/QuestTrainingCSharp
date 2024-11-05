using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeWorking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime

            DateTime dt = DateTime.Now;
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
            var myDt = new DateTime(2024, 11, 05, 17, 50, 49);
            Console.WriteLine(myDt);

            //display the age of person
            Console.Write("Enter Your Date of birth (DD/MM/YYYY):");
            DateTime Date = DateTime.Parse(Console.ReadLine());
            DateTime dtt = DateTime.Now;

            int age = dtt.Year - Date.Year;

            //calculating age
            Console.WriteLine($"Your age is :{age}");

            DateTime futureDate = dt.AddDays(10); 
            DateTime futureTime = dt.AddHours(5);

            Console.WriteLine(futureDate);
            Console.WriteLine(futureTime);

            var ds = DateTime.Now - TimeSpan.FromDays(365);
            Console.WriteLine(ds);
            Console.WriteLine(ds.Day);
            Console.WriteLine(ds.Year);

            // Difference using TimeSpan
            TimeSpan difference = DateTime.Now.Subtract(Date);
            Console.WriteLine($"Days since birth: {difference.Days}"); 
            Console.WriteLine($"Total Hours: {difference.TotalHours}"); 

        }
    }
}
