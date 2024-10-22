using ConsoleAppBookMemberGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric.Data
{
    internal static class DataStore
    {
        public static List<Books> Books;
        public static List<Member> Members;
        static DataStore()
        {
            Books = new List<Books>
            {
                new Books{ Id = 1, BookName ="Book 1"},
                new Books { Id  = 2, BookName = "Book 2"},
                new Books { Id = 3, BookName = "Book 3"}
            };
            Members = new List<Member>
            {
                new Member{ Id = 100, Name = "Gatha", Email ="g@gmail.com",BookId = 1},
                new Member{ Id = 101, Name = "Geethu", Email ="gee@gmail.com",BookId = 1},
                new Member{ Id = 102, Name = "Manu", Email ="ma@gmail.com",BookId = 2},
                new Member{ Id = 103, Name = "Midhun", Email ="g@gmail.com",BookId = 3},
                new Member{ Id = 104, Name = "Leela", Email ="lee@gmail.com",BookId = 2},


            };
        }
    }
}
