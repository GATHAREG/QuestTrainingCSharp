using BookManagement.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Entities
{
    internal class Book
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        public BookType BookType { get; set; }

        public int Price {  get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Title :{Title},Description : {Description},Author : {Author}";
        }



    }
}
