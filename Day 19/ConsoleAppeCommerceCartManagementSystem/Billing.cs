using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppeCommerceCartManagementSystem
{
    internal class Billing
    {
        public decimal TotalPrice(Cart cart,IDiscount discount)
        {
            int total = 0;
            decimal original = 0;

           
                total = cart.GetItems().Sum(x => x.Price*x.Quantity);

            
            return original = discount.GetDiscount(total);
            


        }
    }
}
