// Project04


using System;

using static System.Console;

namespace Project04
{ 

    public class Program
    {

        struct Phone
        {
            public int PhoneNumber;
            public string? Manufacturer;
            public string? Model;
            public string? OperatingSystem;
            public double DiagonalScreenSize;

            public Phone(int phoneNumber, string manufacturer, string model, string operatingSystem, double diagonalScreenSize)
            {
                this.PhoneNumber = phoneNumber;
                this.Manufacturer = manufacturer;
                this.Model = model;
                this.OperatingSystem = operatingSystem;
                this.DiagonalScreenSize = diagonalScreenSize;
            }

        }

        public static void Main(string[] args)
        {
            ConsoleColor fontColor;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThis is Program04\n");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nHow many phones would you like to enter?\n");

            int amountOfPhones;

            int.TryParse(Console.ReadLine(), out amountOfPhones);

            Phone[] phoneArray = new Phone[amountOfPhones];

            int phoneNumber;
            string? manufacturer;
            string? model;
            string? operatingSystem;
            double diagonalScreenSize;

            for (int i = 0; i < amountOfPhones; i++)
            {
                phoneArray[i] = new Phone();

                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the phone number (" + (i + 1) + ")\n");

                int.TryParse(Console.ReadLine(), out phoneNumber);

                phoneArray[i].PhoneNumber = phoneNumber;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the phone's manufacturer (" + (i + 1) + ")\n");

                manufacturer = Console.ReadLine();

                phoneArray[i].Manufacturer = manufacturer;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the phone's model (" + (i + 1) + ")\n");

                model = Console.ReadLine();

                phoneArray[i].Model = model;



                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the phone's operating system (" + (i + 1) + ")\n");

                operatingSystem = Console.ReadLine();

                phoneArray[i].OperatingSystem = operatingSystem;




                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nPlease enter the phone's diagonal screen size (" + (i + 1) + ")\n");

                double.TryParse(Console.ReadLine(), out diagonalScreenSize);

                phoneArray[i].DiagonalScreenSize = diagonalScreenSize;


                fontColor = ConsoleColor.White;

                Headers(fontColor, "\nYou entered the followig information for phone (" + (i + 1) + ") :\n");

                WriteLine("\n" + phoneArray[i].PhoneNumber + "\n" + phoneArray[i].Manufacturer + "\n" + phoneArray[i].Model + "\n" + phoneArray[i].OperatingSystem + "\n" + phoneArray[i].DiagonalScreenSize + "\n");

            }

            if (amountOfPhones > 0)
            {

                char createAccConfirm;

                if (amountOfPhones == 1)
                {
                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\nThank you for adding a phone, would you like to create an account with us? (y/n)\n");

                }
                else
                {
                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\nThank you for adding the phones, would you like to create an account with us? (y/n)\n");
                }



                createAccConfirm = Console.ReadKey().KeyChar;

                if (createAccConfirm == 'y' || createAccConfirm == 'Y')
                {
                    Account account1 = new Account();

                    int mainPhoneNumber;
                    string? name;
                    string? adress;
                    int creditCardNumber;

                    char mainPhoneConfirm;

                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\n\nWould you like to use the phone number of the first phone as the main phone for the account? (y/n)\n");

                    mainPhoneConfirm = Console.ReadKey().KeyChar;

                    if (mainPhoneConfirm == 'y' || mainPhoneConfirm == 'Y')
                    {
                        account1.PhoneNumber = phoneArray[0].PhoneNumber;
                    }

                    else
                    {
                        fontColor = ConsoleColor.White;

                        Headers(fontColor, "\n\nPlease type your main phone number\n");

                        int.TryParse(Console.ReadLine(), out mainPhoneNumber);

                        account1.PhoneNumber = mainPhoneNumber;
                    }





                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\n\nPlease type your name\n");

                    name = Console.ReadLine();

                    account1.CustomerName = name;



                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\nPlease type your adress\n");

                    adress = Console.ReadLine();

                    account1.Adress = adress;

                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\nPlease type your credit card number\n");

                    int.TryParse(Console.ReadLine(), out creditCardNumber);

                    account1.CreditCardNumber = creditCardNumber;

                    char planConfirm;

                    fontColor = ConsoleColor.White;

                    Headers(fontColor, "\nWould you like to have a plan with us? We currently have a 40% discount for every phone added after the main phone!\n(y/n)\n");

                    planConfirm = Console.ReadKey().KeyChar;



                    if (planConfirm == 'y' || planConfirm == 'Y')
                    {

                        double baseCostForEachPhone = 20;
                        double discountPercent = 40;
                        double costDiscountPerPhone = ((amountOfPhones - 1) * ((baseCostForEachPhone) * (1 - (discountPercent / 100))));
                        double planCost;
                        string planCostCurrency = " dollars";

                        planCost = baseCostForEachPhone + costDiscountPerPhone;

                        fontColor = ConsoleColor.White;

                        if (amountOfPhones == 1)
                        {
                            Headers(fontColor, "\n\nYou have " + amountOfPhones + " phone in the system, thus the total plan cost per month will be " + planCost + planCostCurrency + "\n");
                        }

                        else
                        {
                            Headers(fontColor, "\n\nYou have " + amountOfPhones + " phones in the system, thus the total plan cost per month will be " + planCost + planCostCurrency + "\n");
                        }



                        double initialMinutes = 30;

                        account1.MinutesOwned = initialMinutes;

                        char addMinutesConf;

                        string costPerMinuteCurrency = "cents";

                        double minutesAdded;

                        double costPerMinute = .2;

                        fontColor = ConsoleColor.White;

                        Headers(fontColor, "\nYou have " + initialMinutes + " initial minutes for calls, would you like to add more? (y/n)\n");

                        addMinutesConf = Console.ReadKey().KeyChar;

                        if (addMinutesConf == 'y' || addMinutesConf == 'Y')
                        {

                            account1.CostPerMinute = costPerMinute;

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n\nHow many minutes would you like to add? Our cost per minute is " + costPerMinute + " " + costPerMinuteCurrency + "\n");

                            double.TryParse(Console.ReadLine(), out minutesAdded);

                            account1.MinutesAdded = minutesAdded;

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\n" + minutesAdded + " minutes will be " + account1.CalculateCharge() + " " + planCostCurrency);

                            fontColor = ConsoleColor.White;

                            Headers(fontColor, "\nTransaction completed, " + minutesAdded + " minutes were added to your account! You now have " + account1.AdjustMinutesIncrease() + " minutes\n");
                        }

                        char makeCallConf;

                        fontColor = ConsoleColor.White;

                        Headers(fontColor, "\n\nWould you like to make a call? You have " + account1.MinutesOwned + " minutes remaining (y/n)\n");

                        makeCallConf = Console.ReadKey().KeyChar;



                        if (makeCallConf == 'y' || makeCallConf == 'Y')
                        {
                            char addMoreMin;

                            do
                            {
                                double callLength;

                                fontColor = ConsoleColor.White;

                                Headers(fontColor, "\n\nHow much time would you like to use on the call?\n");

                                double.TryParse(Console.ReadLine(), out callLength);

                                account1.MinutesUsed = callLength;

                                fontColor = ConsoleColor.White;

                                Headers(fontColor, "\nCall successful! You have " + account1.AdjustMinutesDecrease() + " minutes left on your account!\n");

                                if (account1.MinutesOwned == 0)
                                {

                                    fontColor = ConsoleColor.White;

                                    Headers(fontColor, "\n\nYou have run out of minutes for your plan. Would you like to add more? (y/n)\n");

                                    fontColor = ConsoleColor.White;

                                    addMoreMin = Console.ReadKey().KeyChar;

                                    if (addMoreMin == 'y' || addMoreMin == 'Y')
                                    {

                                        Headers(fontColor, "\n\nHow many minutes would you like to add? Our cost per minute is still " + costPerMinute + " " + costPerMinuteCurrency + "\n");

                                        double.TryParse(Console.ReadLine(), out minutesAdded);

                                        account1.MinutesAdded = minutesAdded;

                                        fontColor = ConsoleColor.White;

                                        Headers(fontColor, "\n" + minutesAdded + " minutes will be " + account1.CalculateCharge() + " " + planCostCurrency);

                                        fontColor = ConsoleColor.White;

                                        Headers(fontColor, "\nTransaction completed, " + minutesAdded + " minutes were added to your account! You now have " + account1.AdjustMinutesIncrease() + " minutes\n");

                                        fontColor = ConsoleColor.White;

                                    }

                                }

                                if (account1.MinutesOwned > 0)
                                {
                                    fontColor = ConsoleColor.White;

                                    Headers(fontColor, "\nWould you like to make another call? You have " + account1.MinutesOwned + " minutes available! (y/n)\n");

                                    makeCallConf = Console.ReadKey().KeyChar;
                                }
                                else
                                {
                                    makeCallConf = 'n';
                                }


                            } while (makeCallConf == 'y' || makeCallConf == 'Y');
                        }

                    }

                }
            }



            WriteLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThank you for running Program04\n");


            ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to proceed.");
            ReadKey(true);
        }

        static void Headers(ConsoleColor fontColor, string message)
        {
            ForegroundColor = fontColor;
            WriteLine(message);
            ResetColor();
        }
    }
}