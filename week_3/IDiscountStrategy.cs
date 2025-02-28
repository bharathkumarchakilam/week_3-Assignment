using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface IDiscountStrategy
    {
        double ApplyDiscount(double price);
    }

    class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double price) => price;
    }

    class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percentage;
        public PercentageDiscount(double percentage) => _percentage = percentage;

        public double ApplyDiscount(double price) => price - (price * _percentage / 100);
    }

    class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _amount;
        public FixedAmountDiscount(double amount) => _amount = amount;

        public double ApplyDiscount(double price) => Math.Max(price - _amount, 0);
    }

    class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateTotal(double price)
        {
            return _discountStrategy.ApplyDiscount(price);
        }
    }

    //class Program20
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter original price: ");
    //        double price = double.Parse(Console.ReadLine());

    //        Console.WriteLine("Choose discount type: 1. No Discount  2. 10% Discount  3. $20 Discount");
    //        int choice = int.Parse(Console.ReadLine());

    //        IDiscountStrategy discountStrategy = choice switch
    //        {
    //            1 => new NoDiscount(),
    //            2 => new PercentageDiscount(10),
    //            3 => new FixedAmountDiscount(20),
    //            _ => throw new ArgumentException("Invalid choice")
    //        };

    //        ShoppingCart cart = new ShoppingCart(discountStrategy);
    //        double finalPrice = cart.CalculateTotal(price);

    //        Console.WriteLine($"Final Price after discount: {finalPrice}");
    //    }
    //}
}
