using StrategyPatternAssignmentConsole.Products;
using StrategyPatternAssignmentConsole.OnlineStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternAssignmentConsole.Interfaces;

namespace StrategyPatternAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Store!");

            var shoppingCart = new ShoppingCart();
            bool readyToCheckOut = false;
            do
            {
                var product = Menu.ChooseProduct();

                if (product.GetType() == typeof(NoProduct))
                    Console.WriteLine("Thank you for stopping by!");
                else
                {
                    Console.WriteLine($"The cost for your product according to your choices is {product.ProductCost}");
                    Console.WriteLine();
                    shoppingCart.ProductsToBePurchased.Add(product);
                }

                Console.WriteLine("Are you ready for checkout? [Y]es OR [N]o");
                string response = Console.ReadLine();
                readyToCheckOut = response.Contains("Y") ? true : false;
                
            } while (!readyToCheckOut);

            if (readyToCheckOut)
            {
                Console.WriteLine($"The cost for all items in your Shopping cart is {shoppingCart.TotalProductsCost}");
                
                var paymentMethod = (IPaymentFeeStrategy)Menu.ChoosePaymentMethod();

                Console.WriteLine($"Your order, after all fees, will cost {shoppingCart.CalculateFinalCost(paymentMethod)}");
                Console.WriteLine();

                Console.WriteLine("Thank you for your purchase!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("We hope to see you again soon!");
                Console.WriteLine();
            }

        }

    }
}
