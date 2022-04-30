using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Console;

namespace Project03
{
    internal class Restaurant
    {
        private string? city;
        private string? chef;
        private string? cuisineType;
        private int aaaDiamondRating;

        public Restaurant() { }

        public Restaurant(string? city, string? chef, string? cuisineType, int aaaDiamondRating)
        {
            this.city = city;
            this.chef = chef;
            this.cuisineType = cuisineType;
            this.aaaDiamondRating = aaaDiamondRating;
        }

        public string? City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string? Chef
        {
            get
            {
                return chef;
            }

            set
            {
                chef = value;
            }
        }

        public string? CuisineType
        {
            get
            {
                return cuisineType;
            }

            set
            {
                cuisineType = value;
            }
        }

        public int AAADiamondRating
        {
            get
            {
                return aaaDiamondRating;
            }

            set
            {
                aaaDiamondRating = value;
            }
        }

        public string RestaurantInfo()
        {
            string fullString;

            fullString = ("\nIn " + city + " there is a chef named " + chef + " who specializes in " + cuisineType + " cuisine. Their restaurant has a rating of '" + aaaDiamondRating.ToString() + "'\n");

            return fullString;
        }

    }
}
