using BookManagement.Entities;
using BookManagement.Entities.Types;
using BookManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookManagement
    {

        private readonly IStorageService _storageService;
        public BookManagement(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var book = new Book();
            book.Id = Guid.NewGuid().ToString().Trim();
            Console.Write("Enter the title: ");
            book.Title = Console.ReadLine();

            Console.Write("Enter the Description: ");
            book.Description = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();
            Console.Write("Price:");
            book.Price = int.Parse(Console.ReadLine());

            Console.Write("Book Type: 1. Novel: 2. Fiction: ");
            var type = Console.ReadLine();
            book.BookType = type == "1" ? BookType.Novel : BookType.Fiction;
            _storageService.Save(book);

        }

        public void Remove()
        {
            Console.Write("Enter the book id: ");
            var id = Console.ReadLine();
            _storageService.Delete(id);

        }

        public void Update()
        {

        }

        public void Search()
        {
            Console.Write("Enter the title of book: ");
            string title = Console.ReadLine();

            var bookk = _storageService.Search(title);
            if(bookk == null)
            {
                Console.WriteLine("Book not found!");
                return;
            }
            Console.WriteLine(bookk);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

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
