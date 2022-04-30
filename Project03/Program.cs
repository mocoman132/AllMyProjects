// Project03

using System;
// With this line we don't need 'Console' in our code
using static System.Console;

namespace Project03
{
    class Automobile
    {


        //PDDC

        public Automobile() { }

        //PDC

        public Automobile(double speed, string? make, string? model, string? color)
        {
            this.speed = speed;
            this.make = make;
            this.model = model;
            this.color = color;
        }


        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public string? Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }
        public string? Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string? Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }


        private double speed;
        private string? make;
        private string? model;
        private string? color;


    }

    public class Program
    {

        public static void Main(string[] args)
        {
            ConsoleColor fontColor;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThis is Program03");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nHow many automobiles would you like to create?\n");

            int amountOfCars;

            int.TryParse(Console.ReadLine(), out amountOfCars);

            Automobile[] automobileArray = new Automobile[amountOfCars];

            string? make;
            string? model;
            string? color;
            int speed;

            for (int i = 0; i < amountOfCars; i++)
            {
                automobileArray[i] = new Automobile();

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the make of automobile (" + (i + 1) + ")\n");

                make = Console.ReadLine();

                automobileArray[i].Make = make;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the model of automobile (" + (i + 1) + ")\n");
                model = Console.ReadLine();

                automobileArray[i].Model = model;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the color of automobile (" + (i + 1) + ")\n");
                color = Console.ReadLine();

                automobileArray[i].Color = color;

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nYou entered the followig information for automobile (" + (i + 1) + ") :");

                WriteLine("\n" + automobileArray[i].Make + "\n" + automobileArray[i].Model + "\n" + automobileArray[i].Color + "\n");

            }

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nWould you like to set a speed for an automobile? (y/n)\n");

            char confirmation;

            confirmation = Console.ReadKey().KeyChar;

            while (confirmation == 'y')
            {
                fontColor = ConsoleColor.White;

                Headers(fontColor, "\n\nPlease type the number of the automobile that you would like to set the speed of from the following:");

                for (int i = 0; i < automobileArray.Length; i++)
                {
                    WriteLine("\n" + automobileArray[i].Make + "(" + (i + 1) + ")\n");
                }

                int setSpeedtoCar;

                int.TryParse(Console.ReadLine(), out setSpeedtoCar);

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nIn mph, what speed would you like to set for " + automobileArray[(setSpeedtoCar - 1)].Make + "?\n");

                int.TryParse(Console.ReadLine(), out speed);

                automobileArray[(setSpeedtoCar - 1)].Speed = speed;

                WriteLine("\nYou have set the speed of " + automobileArray[(setSpeedtoCar - 1)].Make + " to " + automobileArray[(setSpeedtoCar - 1)].Speed + "\n");

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nWould you like to set a speed for another automobile? (y/n)\n");

                confirmation = Console.ReadKey().KeyChar;
            }


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\n\nWould you like to see or change the speed of any automobile before moving on? (y/n)\n");

            char speedConfirmation;

            speedConfirmation = Console.ReadKey().KeyChar;




            if (speedConfirmation == 'y')
            {
                char seeOrChangeSpeedConf;

                do
                {


                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\n\nWould you like to:\n\n(1) Show the speed of an automobile\n(2) Increase the speed of an automobile\n(3) Decrease the speed of an automobile\n");

                    int selectSpeedAction;

                    int.TryParse(Console.ReadLine(), out selectSpeedAction);

                    if (selectSpeedAction == 1)
                    {

                        char showCarConfirmation;

                        do
                        {

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n\nBy typing the number, which automobile's speed would you like to see?");

                            for (int i = 0; i < automobileArray.Length; i++)
                            {
                                WriteLine("\n" + "(" + (i + 1) + ")" + automobileArray[i].Make + "\n");
                            }

                            int showCarSpeed;

                            int.TryParse(Console.ReadLine(), out showCarSpeed);

                            fontColor = ConsoleColor.White;

                            WriteLine("\nThe speed of " + automobileArray[(showCarSpeed - 1)].Make + " is " + automobileArray[(showCarSpeed - 1)].Speed);

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\nWould you like to see the speed of another automobile? (y/n)\n");

                            showCarConfirmation = Console.ReadKey().KeyChar;
                        } while (showCarConfirmation == 'y');
                    }

                    if (selectSpeedAction == 2)
                    {
                        char incCarConfirmation;

                        do

                        {
                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n\nBy typing the number, which automobile's speed would you like to increase?");

                            for (int i = 0; i < automobileArray.Length; i++)
                            {
                                WriteLine("\n" + "(" + (i + 1) + ")" + automobileArray[i].Make + "\n");
                            }

                            int incCarSpeed;

                            int.TryParse(Console.ReadLine(), out incCarSpeed);

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n\nHow many mph would you like to increase the speed of " + automobileArray[(incCarSpeed - 1)].Make + " by? (current speed: " + automobileArray[(incCarSpeed - 1)].Speed + ")\n");

                            int incAmountCarSpeed;

                            int.TryParse(Console.ReadLine(), out incAmountCarSpeed);

                            automobileArray[incCarSpeed - 1].Speed = (automobileArray[incCarSpeed - 1].Speed + incAmountCarSpeed);

                            Headers(fontColor, "\nWould you like to increase the speed of another automobile? (y/n)\n");

                            incCarConfirmation = Console.ReadKey().KeyChar;

                        } while (incCarConfirmation == 'y');

                    }

                    if (selectSpeedAction == 3)
                    {
                        char decCarConfirmation;

                        do

                        {
                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n\nBy typing the number, which automobile's speed would you like to decrease?");

                            for (int i = 0; i < automobileArray.Length; i++)
                            {
                                WriteLine("\n" + "(" + (i + 1) + ")" + automobileArray[i].Make + "\n");
                            }

                            int decCarSpeed;

                            int.TryParse(Console.ReadLine(), out decCarSpeed);

                            WriteLine("\nBy how many mph would you like to decrease the speed of " + automobileArray[(decCarSpeed - 1)].Make + " by? (current speed: " + automobileArray[(decCarSpeed - 1)].Speed + ")\n");

                            int incAmountCarSpeed;

                            int.TryParse(Console.ReadLine(), out incAmountCarSpeed);

                            automobileArray[decCarSpeed - 1].Speed = (automobileArray[decCarSpeed - 1].Speed - incAmountCarSpeed);

                            Headers(fontColor, "\nWould you like to decrease the speed of another automobile? (y/n)\n");

                            decCarConfirmation = Console.ReadKey().KeyChar;

                        } while (decCarConfirmation == 'y');

                    }

                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\n\nWould you like to see or change the speed of any more automobiles before moving on? (y/n)\n");
                    seeOrChangeSpeedConf = Console.ReadKey().KeyChar;

                } while (seeOrChangeSpeedConf == 'y');
            }

            Restaurant restaurant1 = new Restaurant();

            string? resCity;
            string? resChef;
            string? resCuisine;
            int resDiamondRating;


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the city name:\n");

            resCity = Console.ReadLine();

            restaurant1.City = resCity;


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the chef's name:\n");

            resChef = Console.ReadLine();

            restaurant1.Chef = resChef;


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the cuisine type:\n");

            resCuisine = Console.ReadLine();

            restaurant1.CuisineType = resCuisine;


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the diamond rating:\n");

            int.TryParse(Console.ReadLine(), out resDiamondRating);

            restaurant1.AAADiamondRating = resDiamondRating;

            WriteLine("\n" + restaurant1.RestaurantInfo() + "\n");


            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nHow many paintings would you like to create?\n");

            int amountOfPaintings;

            int.TryParse(Console.ReadLine(), out amountOfPaintings);

            Painting[] paintingArray = new Painting[amountOfPaintings];

            string? artist;
            string? genre;
            string? country;
            int year;
            double wholesalePrice;
            double commission;
            double tax;
            double duty;

            for (int i = 0; i < amountOfPaintings; i++)
            {
                paintingArray[i] = new Painting();

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the artist of the painting (" + (i + 1) + ")\n");

                artist = Console.ReadLine();

                paintingArray[i].Artist = artist;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the genre of the paiting (" + (i + 1) + ")\n");
                genre = Console.ReadLine();

                paintingArray[i].Genre = genre;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the country of the painting (" + (i + 1) + ")\n");
                country = Console.ReadLine();

                paintingArray[i].Country = country;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the year that the paiting (" + (i + 1) + ") was made\n");
                int.TryParse(Console.ReadLine(), out year);

                paintingArray[i].Year = year;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the wholesalePrice that paiting (" + (i + 1) + ") is worth\n");
                double.TryParse(Console.ReadLine(), out wholesalePrice);

                paintingArray[i].WholesalePrice = wholesalePrice;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nYou entered the followig information for the painting (" + (i + 1) + ") :");

                WriteLine("\n" + paintingArray[i].Artist + "\n" + paintingArray[i].Genre + "\n" + paintingArray[i].Country + "\n" + paintingArray[i].Year + "\n" + paintingArray[i].WholesalePrice + "\n");

                fontColor = ConsoleColor.White;

            }

            char nextPaintConfirmationl;

            do
            {
                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nType the number of the painting you would like to calculate the retailPrice of");

                for (int i = 0; i < paintingArray.Length; i++)
                {
                    WriteLine("\n" + paintingArray[i].Artist + "(" + (i + 1) + ")\n");
                }

                int choosePaintRetail;

                int.TryParse(Console.ReadLine(), out choosePaintRetail);

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nYou picked:" + paintingArray[(choosePaintRetail - 1)].Artist + "\n");

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease input the commission % for the painting\n");

                double.TryParse(Console.ReadLine(), out commission);

                paintingArray[(choosePaintRetail - 1)].PercentCommission = commission;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease input the tax %\n");

                double.TryParse(Console.ReadLine(), out tax);

                paintingArray[(choosePaintRetail - 1)].PercentTax = tax;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease input the duty %\n");

                double.TryParse(Console.ReadLine(), out duty);

                paintingArray[(choosePaintRetail - 1)].PercentDuty = duty;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nThe retail price of the painting is " + paintingArray[(choosePaintRetail - 1)].RetailPrice());

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\n\nWould you like to calculate the retail price of another painting? (y/n)\n");

                nextPaintConfirmationl = Console.ReadKey().KeyChar;



            } while (nextPaintConfirmationl == 'y');

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\n\nThank you for running Program03.\n");

            ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to proceed.");
            ReadKey(true);


            static void Headers(ConsoleColor fontColor, string message)
            {
                ForegroundColor = fontColor;
                WriteLine(message);
                ResetColor();
            }

        }
    }
}