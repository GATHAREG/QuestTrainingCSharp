using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppeCommerceCartManagementSystem
{
    internal interface IDiscount
    {
        decimal GetDiscount(int total);

    }
    class PercentageDiscount : IDiscount
    {
        private decimal _percentage = 20;
        public decimal GetDiscount(int total)
        {
            return total- ((total * _percentage)/100);
        }
    }
}
