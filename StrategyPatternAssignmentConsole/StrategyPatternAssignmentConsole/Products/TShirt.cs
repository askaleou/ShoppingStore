using StrategyPatternAssignmentConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.Products
{
    class TShirt : Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        public TShirt()
        {
            Color = Menu.ChooseColor();
            Size = Menu.ChooseSize();
            Fabric = Menu.ChooseFabric();
        }

        public override decimal ProductCost
        {
            get => CalculateProductCost(); 
        }

        public new decimal CalculateProductCost()
        {
            return Color.Cost + Size.Cost + Fabric.Cost;
        }

    }
}
