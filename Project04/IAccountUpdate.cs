using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project04
{
    internal interface IAccountUpdate
    {
        double BalanceOwed { get; set; }
        double MinutesUsed { get; set; }
        double CostPerMinute { get; set; }
        double MinutesOwned { get; set; }
        double MinutesAdded { get; set; }
        double CalculateCharge();

        double AdjustMinutesDecrease();

        double AdjustMinutesIncrease();

    }
}
