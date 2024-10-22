using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook
{
    internal class Contact
    {
        public int PhoneNumber {  get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name :{Name},  Email : {Email}, PhoneNumber : {PhoneNumber}";
        }
    }
}
