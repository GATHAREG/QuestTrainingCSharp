using ConsoleAppBookMemberGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookRepository = new BookRepository();
            var result = bookRepository.GetById(10);
            if (result.Success)
            {
                Console.WriteLine(result.Data.BookName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            var res = bookRepository.GetByName("Book 1");
            if (res.Success)
            {
                Console.WriteLine(res.Data.BookName);

            }
            else
            {
                Console.WriteLine(res.Message);
            }

            var memberRepository = new MemberRepository();

            var memberResult = memberRepository.GetByName("Gatha");
            if (memberResult.Success)
            {
                Console.WriteLine(memberResult.Data.BookId);
                Console.WriteLine(memberResult.Data.Email);
            }
            else
            {
                Console.WriteLine(memberResult.Message);
            }

            var memberByEmail = memberRepository.GetByEmail("gg@gamil.com");
            if (memberByEmail.Success)
            {
                Console.WriteLine(memberByEmail.Data.Name);
            }
            else
            {
                Console.WriteLine(memberByEmail.Message);
            }



        }
    }
}
