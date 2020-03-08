using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.Products
{
    class Fabric
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Fabric(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
