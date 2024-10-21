using BankAppLinq.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppLinq
{
      internal static class Methods
   {
      public static  bool IsEven(this int num)
      {
          if (num % 2 == 0)
          {
              return true;

          }
          return false;
      }

      public static bool IsOdd(this int num)
      {
          if ((num % 2) != 0)
          {
              return true;
          }
          return false;
      }
   }
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Balance {  get; set; }

    }
    class Transact
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int Amount { get; set; }
        public  DateTime  DayTime{ get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new List<Account>()
            {
                new Account{Id = 1, Name = "gatha",Balance = 1900},
                new Account{Id = 2, Name = "minnu" ,Balance = 2000},
                new Account{Id = 3, Name = "Manu" , Balance = 35000 },
                new Account{Id = 4, Name = "Midhun" ,Balance = 5900}
            };
            var transact = new List<Transact>()
            {
                new Transact{Id = 100,FromId = 1, ToId = 2, Amount = 1000,DayTime = DateTime.Now},
                new Transact {Id = 101,FromId = 3, ToId = 4 , Amount = 500 ,DayTime = DateTime.Now},
            
            };

            //linq query

            var tr = from transaction in transact 
                      join fromAccount in account on transaction.FromId equals fromAccount.Id
                      join toAccount in account on transaction.ToId equals toAccount.Id
                      select new
                      {
                         TransactionId = transaction.Id,
                         FromAccountName = fromAccount.Name,
                         ToAccountName = toAccount.Name,
                         Amount = transaction.Amount,
                         Date = transaction.DayTime

                      };

            //method

            var transactionDetails = transact.
                Join(
                  account,
                  t=>t.FromId,
                  a=>a.Id,
                  (transaction,accounts) => new {Transaction = transaction,FromAccount =  accounts})
                .Join(
                    account,
                    res => res.Transaction.Id,
                    a => a.Id,
                    (res, toAccount) => new
                    {
                        TransactionId = res.Transaction.Id,
                        FromAccountName = res.FromAccount.Name,
                        ToAccountName = toAccount.Name,
                        Amount = res.Transaction.Amount,
                        Date = res.Transaction.DayTime

                    });

                 foreach (var item in tr)
                 {
                     Console.WriteLine($"from :{item.FromAccountName} To:{item.ToAccountName} Amount:{item.Amount} Date :{item.Date}");

                  }

            int data = 12;
            Console.WriteLine(data.IsEven());
            Console.WriteLine(data.IsOdd());


        }
    }
}
