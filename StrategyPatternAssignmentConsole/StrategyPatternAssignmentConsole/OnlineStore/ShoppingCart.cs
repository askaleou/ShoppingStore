using StrategyPatternAssignmentConsole.Interfaces;
using StrategyPatternAssignmentConsole.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.OnlineStore
{
    class ShoppingCart : IShoppingCartStrategy
    {
        public List<Product> ProductsToBePurchased { get; set; }
        public decimal TotalProductsCost
        {
            get
            {
                decimal totalProductCost = 0;

                foreach (var product in ProductsToBePurchased)
                {
                    totalProductCost += product.CalculateProductCost();
                }

                return totalProductCost;
            }
        }

        public ShoppingCart()
        {
            ProductsToBePurchased = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            ProductsToBePurchased.Add(product);
        }

        public decimal CalculateFinalCost(IPaymentFeeStrategy payment)
        {
            return TotalProductsCost * payment.PaymentFees;
        }
    }
}
