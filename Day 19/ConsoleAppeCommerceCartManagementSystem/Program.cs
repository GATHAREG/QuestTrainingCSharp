using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppeCommerceCartManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem("Colgate", 70, 45));
            cart.Add(new CartItem("Product 2", 16, 780));
            cart.Add(new CartItem("Product 3",10, 80));

            cart.Update("Colgate", 77, 50);
            cart.Remove("Product 3");

            var bill = new Billing();
            var discount = new PercentageDiscount();
            decimal billValue = bill.TotalPrice(cart, discount);
            Console.WriteLine(billValue);




        }
    }
}
