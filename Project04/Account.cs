using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project04
{
    internal class Account : IAccountUpdate
    {
        public Account() { }

        public Account(int phoneNumber, string customerName, string adress, int creditCardNumber, double balanceOwed, double minutesUsed, double costPerMinute, double minutesOwned, double minutesAdded)
        {
            this.PhoneNumber = phoneNumber;
            this.CustomerName = customerName;
            this.Adress = adress;
            this.CreditCardNumber = creditCardNumber;
            this.BalanceOwed = balanceOwed;
            this.MinutesUsed = minutesUsed;
            this.CostPerMinute = costPerMinute;
            this.MinutesOwned = minutesOwned;
            this.MinutesAdded = minutesAdded;
        }

        public int PhoneNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? Adress { get; set; }
        public int CreditCardNumber { get; set; }


        private double charge;

        public double BalanceOwed { get; set; }
        public double MinutesUsed { get; set; }
        public double CostPerMinute { get; set; }

        public double MinutesOwned { get; set; }

        public double MinutesAdded { get; set; }
        public double CalculateCharge()
        {
            charge = BalanceOwed + (MinutesAdded * CostPerMinute);

            return charge;
        }

        public double AdjustMinutesDecrease()
        {
            MinutesOwned = (MinutesOwned - MinutesUsed);

            return MinutesOwned;
        }

        public double AdjustMinutesIncrease()
        {
            MinutesOwned = (MinutesOwned + MinutesAdded);

            return MinutesOwned;
        }

    }
}
