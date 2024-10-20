using BookManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var bookManger = new BookManagement(storageService);
            bookManger.Run();


        }
    }
}
