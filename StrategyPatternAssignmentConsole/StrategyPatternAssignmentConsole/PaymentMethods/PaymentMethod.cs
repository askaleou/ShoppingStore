using StrategyPatternAssignmentConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.PaymentMethods
{
    class PaymentMethod : IPaymentFeeStrategy
    {
       
        public string Name { get; set; }
        public decimal PaymentFees { get; set; }
        
        public PaymentMethod(string name, decimal paymentFees)
        {
            Name = name;
            PaymentFees = paymentFees;
        }
    }
}
