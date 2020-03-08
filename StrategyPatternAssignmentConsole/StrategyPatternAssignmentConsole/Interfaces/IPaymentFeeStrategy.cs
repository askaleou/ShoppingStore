using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignmentConsole.Interfaces
{
    public interface IPaymentFeeStrategy
    {
        decimal PaymentFees { get; set; }
    }
}
