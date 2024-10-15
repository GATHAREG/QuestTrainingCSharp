// A  credit card application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardApplication
{
    internal class Program
    {
      //list of creditcard
       public static List<CreditCard> creditCards = new List<CreditCard>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Credit Card Management");
                Console.WriteLine("1.Add  Credit Card");
                Console.WriteLine("2.Search Credit Card");
                Console.WriteLine("3.Update Credit Card");
                Console.WriteLine("4.Delete Credit Card");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       Add();
                        break;
                    case 2:
                       Search();
                        break;
                    case 3:
                       Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }

            }
        }
        // function to add
        public static void Add()
        { 
            Console.Write("Enter the CardHolder name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the card number: ");
            int cardNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the expiry in MM/YY: ");
            string expiry = Console.ReadLine();

            Console.Write("Enter the cvc:");
            int cvc = int.Parse(Console.ReadLine());

            var cred = new CreditCard
            {
                HolderName = name,
                CardNumber = cardNum,
                ExpiryMonth = int.Parse(expiry.Split('/')[0]),
                ExpiryYear = int.Parse(expiry.Split('/')[1]),
                Cvc = cvc

            };
            creditCards.Add(cred);
            Console.WriteLine("Credit card details added successfully:");
            Console.WriteLine();
        }
        //function to search
        public static void Search()
        {  
           Console.Write("Enter the card number:");
           int cardnumber = int.Parse(Console.ReadLine());
           bool found = false;
           foreach (var card in creditCards) 
            {
               if (card.CardNumber == cardnumber)
               { 
                    Console.WriteLine($"Card holder name : {card.HolderName}, card Number : {card.CardNumber} , expiry month : {card.ExpiryMonth}, expiry year :{card.ExpiryYear}, cvc number : {card.Cvc} ");
                    found = true;
                    break;
               }
            }
            if (!found)
            {
                Console.WriteLine("There is no card with this number");
            }
        }
        //function to update
        public static void Update()
        {
            Console.Write("Enter the card number to update:");
            int cardnumber = int.Parse(Console.ReadLine());
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardnumber)
                {
                    Console.WriteLine("What you want to update : ");
                    Console.WriteLine("1.Card Holder Name");
                    Console.WriteLine("2.Card expiry ");
                    Console.Write("Enter the option");
                    int subchoice = int.Parse(Console.ReadLine());
                    switch (subchoice)
                    {
                        case 1:
                            Console.Write("Enter the CardHolder name: ");
                            string name = Console.ReadLine();
                            card.HolderName = name;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 2:
                            Console.Write("Enter the expiry in MM/YY: ");
                            string expiry = Console.ReadLine();
                            card.ExpiryMonth = int.Parse(expiry.Split('/')[0]);
                            card.ExpiryYear = int.Parse(expiry.Split('/')[1]);
                            Console.WriteLine("Updated successfully");

                            break;
                        default:
                            Console.WriteLine("Nothing else can update");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("There is no card with that number");
                }
            }

        }
        public static void Delete()
        {

            Console.Write("Enter the card number to delete :");
            int cardnumber = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < creditCards.Count; i++) 
            {
                if (creditCards[i].CardNumber == cardnumber)
                {
                   creditCards.RemoveAt(i);
                    Console.WriteLine("Deleted successfully");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("There is no such card exist!");
            }
            Console.WriteLine();
        }

    }
}
