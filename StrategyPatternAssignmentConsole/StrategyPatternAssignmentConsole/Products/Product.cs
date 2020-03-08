using StrategyPatternAssignmentConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.Products
{
    public abstract class Product : IProductPriceStrategy
    {
        public abstract decimal ProductCost { get; }

        public decimal CalculateProductCost()
        {
            return ProductCost;
        }
    }
}
