// Project01

using System;
// With this line we don't need 'Console' in our code
using static System.Console;

namespace Project01
{

    public class Program
    {



        public static void Main(string[] args)
        {
            ConsoleColor fontColor;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThis is Program01");

            float first;
            float second;
            float third;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease, enter the first float below and press ENTER.\n");

            float.TryParse(ReadLine(), out first);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease, enter the second float below and press ENTER.\n");


            float.TryParse(ReadLine(), out second);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease, enter the last float below and press ENTER.\n");

            float.TryParse(ReadLine(), out third);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nYou entered the following three values:\n" + "\n" + first + "\n" + second + "\n" + third);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThe following are examples of arithmetic using the given floats:");

            float addition = first + second + third;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nAddition:");

            WriteLine("\n" + first + " + " + second + " + " + third + " = " + addition);

            float multiplication = first * second * third;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nMultiplication:");

            WriteLine("\n" + first + " * " + second + " * " + third + " = " + multiplication);

            float division = first / second / third;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nDivision:");

            WriteLine("\n" + "(" + first + " / " + second + ")" + " / " + third + " = " + division);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nImplicit Cast from float into double:\n");

            double newDouble1;
            double newDouble2;
            double newDouble3;

            newDouble1 = first;
            newDouble2 = second;
            newDouble3 = third;

            WriteLine("double newDouble1;");
            WriteLine("double newDouble2;");
            WriteLine("double newDouble3;\n");
            WriteLine("newDouble1 = first;");
            WriteLine("newDouble2 = second;");
            WriteLine("newDouble3 = third;");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nExplicit Cast from float into int:\n");

            int newInt1;
            int newInt2;
            int newInt3;

            newInt1 = (int)first;
            newInt2 = (int)second;
            newInt3 = (int)third;

            WriteLine("int newInt1;");
            WriteLine("int newInt2;");
            WriteLine("int newInt3;\n");
            WriteLine("newInt1 = (int)first;");
            WriteLine("newInt2 = (int)second;");
            WriteLine("newInt3 = (int)third;");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nConverting floats into strings:\n");

            string newString1;
            string newString2;
            string newString3;

            newString1 = first.ToString();
            newString2 = second.ToString();
            newString3 = third.ToString();

            WriteLine("string newString1;");
            WriteLine("string newString2;");
            WriteLine("string newString3;\n");
            WriteLine("newString1 = first.ToString();");
            WriteLine("newString2 = second.ToString();");
            WriteLine("newString3 = third.ToString();");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter one of the following 4 game titles, and the world record speedrun time will be given:\n" + "\nDoom_(1993)" + "\nThe_Legend_of_Zelda" + "\nHalo_Combat_Evolved" + "\nSuper_Mario_Bros\n");

            string? gameTitle;

            gameTitle = ReadLine();

            switch (gameTitle)
            {
                case "Doom_(1993)":
                    WriteLine("\nThe Doom world record speedrun is 1 hour 8 minutes and 52 seconds");
                    break;
                case "The_Legend_of_Zelda":
                    WriteLine("\nThe Legend of Zelda world record speedrun is 27 minutes and 36 seconds");
                    break;
                case "Halo_Combat_Evolved":
                    WriteLine("\nThe Halo Combat Evolved world record speedrun is 1 hour 38 minutes and 57 seconds");
                    break;
                case "Super_Mario_Bros":
                    WriteLine("\nThe Super Mario Bros world record speedrun is 4 minutes and54.948 seconds");
                    break;
                default:
                    WriteLine("\nYou did not correctly type the name of the game.");
                    break;
            }

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nSorting Float Numbers Given Into Ascending Order");

            if (first < second && first < third && second < third)
            {
                WriteLine(third + "\n" + second + "\n" + first);
            }
            else if (first < second && first > third && second > third)
            {
                WriteLine(second + "\n" + first + "\n" + third);
            }
            else if (first > second && first > third && second < third)
            {
                WriteLine(first + "\n" + third + "\n" + second);
            }
            else if (first < second && first < third && second > third)
            {
                WriteLine(second + "\n" + third + "\n" + first);
            }
            else if (first > second && first < third && second < third)
            {
                WriteLine(third + "\n" + first + "\n" + second);
            }
            else if (first > second && first > third && second > third)
            {
                WriteLine(first + "\n" + second + "\n" + third);
            }
            else
            {
                WriteLine("At least two numbers are the same and thus ordering in ascending or descending is not possible");
            }


            //first = 1;
            //second = 2;
            //third = 3;

            //first = 2
            //second = 3
            //third = 1

            //first = 3
            //second = 1
            //third = 2

            //first = 1
            //second = 3
            //third = 2

            //first = 2
            //second = 1
            //third = 3

            //first = 3
            //second = 2
            //third = 1

            WriteLine("\nThank you for running Program01.");


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