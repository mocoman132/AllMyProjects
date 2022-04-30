using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Console;

namespace Project03
{
    internal class Painting
    {

        public Painting() { }

        public Painting(string artist, string genre, string country, int year, double wholesalePrice, double percentCommission, double percentTax, double percentDuty)
        {
            this.Artist = artist;
            this.Genre = genre;
            this.Country = country;
            this.Year = year;
            this.WholesalePrice = wholesalePrice;
            this.PercentCommission = percentCommission;
            this.PercentTax = percentTax;
            this.PercentDuty = percentDuty;

        }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
        public string? Country { get; set; }
        public int Year { get; set; }
        public double WholesalePrice { get; set; }
        public double PercentCommission { get; set; }
        public double PercentTax { get; set; }
        public double PercentDuty { get; set; }


        public double RetailPrice()
        {
            double commission;
            double tax;
            double duty;

            commission = ((WholesalePrice * (1 + (PercentCommission / 100))) - WholesalePrice);
            tax = ((WholesalePrice * (1 + (PercentTax / 100))) - WholesalePrice);
            duty = ((WholesalePrice * (1 + (PercentDuty / 100))) - WholesalePrice);


            double retailPrice;
            retailPrice = (WholesalePrice + commission + tax + duty);
            return retailPrice;
        }

        // need to make tax duty and commission variables and then calculate the price of the paiting given the user info.

    }
}
