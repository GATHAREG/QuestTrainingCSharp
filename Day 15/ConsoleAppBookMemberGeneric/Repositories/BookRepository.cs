using ConsoleAppBookMemberGeneric.Data;
using ConsoleAppBookMemberGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Books>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Books>>
            {
                Success = true,
                Data = books,
            };
        }
        public GenericResponse<Books> GetById(int id)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available",
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = book,
            };

        }
        public GenericResponse<Books> GetByName(string name)

        {
            var bookk = DataStore.Books.FirstOrDefault(x=>x.BookName== name);
            if(bookk == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available",

                };
            }
            return new GenericResponse<Books>
            {
                Success = true,
                Data = bookk,
            };

        }
}
    }

