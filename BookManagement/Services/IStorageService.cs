using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    internal interface IStorageService
    {
        void Save(Book book);
        
        Book Search(string title);

        Book GetById(string id);

        void  Delete(string id);


    }
}
