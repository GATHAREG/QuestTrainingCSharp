using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class DiscountCalculator
    {
        public int CalculateDiscount(Discount discount)
        {
            return discount.GetDiscount();
            // if (membershipType == "Silver") return 10;
            // else if (membershipType == "Gold") return 20;
            // else if (membershipType == "Platinum") return 30;
            // else if (membershipType == "Diamond") return 40;
            // return 0;
        }
    }
    public class Bird
    {
        public string Name { get; set; }

        public virtual void Fly() => Console.WriteLine("I can fly!");
    }

    public class Penguin : Bird
    {
        public override void Fly() => throw new NotImplementedException("Penguins can't fly!");
    }

    public abstract class Discount
    {
        public abstract int GetDiscount();
    }

    public class SilverDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 10;
        }
    }

    public class GoldDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 20;
        }
    }

    public class PlatinumDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 30;
        }
    }

    public class DiamondDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 40;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            var rseult = calculator.CalculateDiscount(new GoldDiscount());
            var b = new Penguin() { Name = "Tweety" }; //it si wronggggggg liskov
            b.Fly();
        }
    }
}
