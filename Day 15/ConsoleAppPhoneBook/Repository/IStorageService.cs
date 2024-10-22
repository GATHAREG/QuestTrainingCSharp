using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook.Repository
{
    internal interface IStorageService
    {
        void Add(Contact contact);

        void Remove(string name);

        void  Search(string input);

        void Update(string name,int number,string email);
    }
}
