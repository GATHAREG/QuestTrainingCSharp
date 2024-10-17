using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11FieldsProperty
{
    internal class Student
   {
     public string Name {  get; set; }
     public string Email { get; set; }

     public string PhoneNumber { get; set; }
     private int age;

      public int Age
      {
        get
        {
            return age;
        }
        set
        {
            if (value > 0 || value < 100)
                age = value;
        }
     }
    }
    internal class Person
    {  
       public string Name { get; set; }
       public string Email {  get; set; }
    }

    internal class Address
   {
       public  string Type {  get; set; }
       public string AddressLine1 { get; set; }
       public string AddressLine2 { get; set; }
       public int PinCode {  get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "gatha";
            person.Email = "gatha@gmail.com";

            var address = new List<Address>
            {
                new Address{ Type = "Home", AddressLine1 = "house",AddressLine2 = "bhavan", PinCode = 123 },
                new Address{ Type = "office", AddressLine1 = "home",AddressLine2 = "bhavan", PinCode = 678}
                   
            };
            person.Address = address;
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Email);
            Console.WriteLine(person.Address[0].Type);
            Console.WriteLine(person.Address[0].AddressLine1);
            Console.WriteLine(person.Address[0].AddressLine2);
            Console.WriteLine(person.Address[0].PinCode);

            // another way of adding address as a list to person

            /* person.Address = new List<Address>();
             * person.Address.Add(new Address{ Type = "Home", AddressLine1 = "house",AddressLine2 = "bhavan", PinCode = 123 });
             * person.Address.Add(new Address{Type = "office", AddressLine1 = "home",AddressLine2 = "bhavan", PinCode = 678});
                   
             */

        }
    }
}
