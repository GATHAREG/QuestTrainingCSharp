using ConsoleAppPhoneBook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name
Phone,
Email (optional)
 
Search by name / or phone
Add new contact
Delete Contact
Update contact */
namespace ConsoleAppPhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();

            var contactMangement = new ContactManagement(storage);

            contactMangement.Run();

        }
    }
}
