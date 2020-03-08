using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.Products
{
    class NoProduct : Product
    {
        public override decimal ProductCost { get; } = 0;
    }
}
