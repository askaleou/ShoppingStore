
using StrategyPatternAssignmentConsole.PaymentMethods;
using StrategyPatternAssignmentConsole.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole
{
    class Menu
    {
        public static Product ChooseProduct()
        {
            var sbProduct = new StringBuilder();
            sbProduct
                .Append("What would you like to purchase today?")
                .AppendLine()
                .Append("1. T-Shirts")
                .AppendLine()
                .AppendLine("2. Nothing");

            Console.Write(sbProduct);
            string productChoice = Console.ReadLine();

            Product product;

            switch (productChoice)
            {

                case "1":
                case "T-Shirt":
                    product = new TShirt();
                    break;
                case "2":
                case "Nothing":
                default:
                    product = new NoProduct();
                    break;
            }
            return product;
        }

        public static Color ChooseColor()
        {
            var sbColor = new StringBuilder();
            sbColor
                .Append("What color do you want the product to be?")
                .AppendLine()
                .Append("1. Red")
                .AppendLine()
                .Append("2. Orange")
                .AppendLine()
                .Append("3. Yellow")
                .AppendLine()
                .Append("4. Green")
                .AppendLine()
                .Append("5. Blue")
                .AppendLine()
                .Append("6. Indigo")
                .AppendLine()
                .AppendLine("7. Violet");

            Console.Write(sbColor);
            string colorChoice = Console.ReadLine();

            Color color;

            switch (colorChoice)
            {
                case "1":
                case "Red":
                    color = new Color("Red", 10);
                    break;
                case "2":
                case "Orange":
                    color = new Color("Orange", 5);
                    break;
                case "3":
                case "Yellow":
                    color = new Color("Yellow", 5);
                    break;
                case "4":
                case "Green":
                    color = new Color("Green", 5);
                    break;
                case "5":
                case "Blue":
                    color = new Color("Blue", 10);
                    break;
                case "6":
                case "Indigo":
                    color = new Color("Indigo", 5);
                    break;
                case "7":
                case "Violet":
                    color = new Color("Violet", 5);
                    break;
                default:
                    Console.WriteLine("You will be getting a random color!");
                    color = new Color("RandomColor", 10);
                    break;
            }
            return color;
        }

        public static Size ChooseSize()
        {
            var sbSize = new StringBuilder();
            sbSize
                .Append("What size do you want the product to be?")
                .AppendLine()
                .Append("1. XS")
                .AppendLine()
                .Append("2. S")
                .AppendLine()
                .Append("3. M")
                .AppendLine()
                .Append("4. L")
                .AppendLine()
                .Append("5. XL")
                .AppendLine()
                .Append("6. XXL")
                .AppendLine()
                .AppendLine("7. XXL");

            Console.Write(sbSize);
            string sizeChoice = Console.ReadLine();

            Size size;

            switch (sizeChoice)
            {
                case "1":
                case "XS":
                    size = new Size("XS", 5);
                    break;
                case "2":
                case "S":
                    size = new Size("S", 6);
                    break;
                case "3":
                case "M":
                    size = new Size("M", 7);
                    break;
                case "4":
                case "L":
                    size = new Size("L", 8);
                    break;
                case "5":
                case "XL":
                    size = new Size("XL", 9);
                    break;
                case "6":
                case "XXL":
                    size = new Size("XXL", 10);
                    break;
                case "7":
                case "XXXL":
                    size = new Size("XXXL", 10);
                    break;
                default:
                    Console.WriteLine("You will be getting a random size!");
                    size = new Size("RandomSize", 10);
                    break;
            }
            return size;
        }

        public static Fabric ChooseFabric()
        {
            var sbFabric = new StringBuilder();
            sbFabric
                .Append("What size do you want the product to be?")
                .AppendLine()
                .Append("1. Wool")
                .AppendLine()
                .Append("2. Cotton")
                .AppendLine()
                .Append("3. Polyester")
                .AppendLine()
                .Append("4. Rayon")
                .AppendLine()
                .Append("5. Linen")
                .AppendLine()
                .Append("6. Cashmere")
                .AppendLine()
                .AppendLine("7. Silk");

            Console.Write(sbFabric);
            string fabricChoice = Console.ReadLine();

            Fabric fabric;

            switch (fabricChoice)
            {
                case "1":
                case "Wool":
                    fabric = new Fabric("Wool", 10);
                    break;
                case "2":
                case "Cotton":
                    fabric = new Fabric("Cotton", 15);
                    break;
                case "3":
                case "Polyester":
                    fabric = new Fabric("Polyester", 20);
                    break;
                case "4":
                case "Rayon":
                    fabric = new Fabric("Rayon", 25);
                    break;
                case "5":
                case "Linen":
                    fabric = new Fabric("Linen", 30);
                    break;
                case "6":
                case "Cashmere":
                    fabric = new Fabric("Cashmere", 35);
                    break;
                case "7":
                case "Silk":
                    fabric = new Fabric("Silk", 40);
                    break;
                default:
                    Console.WriteLine("You will be getting a random fabric!");
                    fabric = new Fabric("RandomFabric", 20);
                    break;
            }
            return fabric;
        }

        public static PaymentMethod ChoosePaymentMethod()
        {
            var sbPaymentMethod = new StringBuilder();
            sbPaymentMethod
                .Append("What is your prefered Payment Method?")
                .AppendLine()
                .Append("1. Cash")
                .AppendLine()
                .Append("2. Credit or Debit Card")
                .AppendLine()
                .AppendLine("3. Bank or Money Transfer");

            Console.Write(sbPaymentMethod);
            string paymentChoice = Console.ReadLine();

            PaymentMethod paymentMethod;

            switch (paymentChoice)
            {
                case "1":
                case "Cash":
                    paymentMethod = new PaymentMethod("Cash", 1);
                    break;
                case "2":
                case "Card":
                case "Credit":
                case "Debit":
                    paymentMethod = new PaymentMethod("Card", 1.20m);
                    break;
                case "3":
                case "Bank":
                case "Transfer":
                    paymentMethod = new PaymentMethod("BankTransfer", 1.15m);
                    break;
                default:
                    Console.WriteLine("You will pay with a random method!");
                    paymentMethod = new PaymentMethod("RandomMethod", 1.25m);
                    break;
            }
            return paymentMethod;
        }




    }
}
