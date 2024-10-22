using ConsoleAppPhoneBook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook
{
    internal class ContactManagement
    {
        private readonly IStorageService  _storageService;

        public ContactManagement(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            
            Console.Write("Enter the phone number");
            int PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            string Email = Console.ReadLine();
            var contact = new Contact
                {
                    PhoneNumber = PhoneNumber, Name = Name, Email = Email 

                };
             

            _storageService.Add(contact);
        }
        public void Remove()
        {
            Console.Write("Enter the name to delete:");
            string name = Console.ReadLine();
            _storageService.Remove(name);


        }
        public void Search()
        {
            Console.Write("Search by phonenumber/name:");
            string input = Console.ReadLine();
            _storageService.Search(input);

        }

        public void Update()
        {
            Console.Write("Enter the name:");
            string name = Console.ReadLine();
            Console.Write("Enter the new phonenumber");
            int number = int.Parse(Console.ReadLine());
            Console.Write("enter the new Email");
            string email = Console.ReadLine();
            _storageService.Update(name,number,email);

        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Conatct");
                Console.WriteLine("2. Search Contact By Phonenumber/Name");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
