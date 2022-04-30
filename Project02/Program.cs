// Project02

using System;

using static System.Console;

namespace Project02
{

    public class Program
    {

        public static void Main(string[] args)
        {

            ConsoleColor fontColor;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThis is Program02\n");

            double first, second, third, fourth, fifth;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the first Double value\n");

            double.TryParse(ReadLine(), out first);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the second Double value\n");

            double.TryParse(ReadLine(), out second);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the third Double value\n");

            double.TryParse(ReadLine(), out third);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the fourth Double value\n");

            double.TryParse(ReadLine(), out fourth);

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the fifth Double value\n");

            double.TryParse(ReadLine(), out fifth);


            double[] myDoubles = new double[5];

            myDoubles[0] = first;
            myDoubles[1] = second;
            myDoubles[2] = third;
            myDoubles[3] = fourth;
            myDoubles[4] = fifth;

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nYou have entered the following values:\n");

            for (int i = 0; i < myDoubles.Length; i++)
            {
                WriteLine(myDoubles[i] + "\n");
            }


            // Sum

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThe values entered, add to:\n");

            double sum = 0;

            for (int i = 0; i < myDoubles.Length; i++)
            {

                sum = (myDoubles[i] + sum);

            }

            WriteLine(sum + "\n");

            // Avg

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThe average of the values entered is:\n");

            double average = (sum / myDoubles.Length);

            WriteLine(average + "\n");

            // Lowest Value

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nFrom the given values, the lowest is:\n");

            double lowestValue = first;

            for (int i = 0; i < myDoubles.Length; i++)
            {

                if (myDoubles[i] < lowestValue)
                {
                    lowestValue = myDoubles[i];
                }

            }

            WriteLine(lowestValue + "\n");

            // Highest Value

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nFrom the given values, the highest is:\n");

            double highestValue = first;

            for (int i = 0; i < myDoubles.Length; i++)
            {

                if (myDoubles[i] > highestValue)
                {
                    highestValue = myDoubles[i];
                }

            }

            WriteLine(highestValue + "\n");

            string?[,] rainfallData = new string[2, 5];

            // First day and it's rainfall data

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter a day of the week\n");

            rainfallData[0, 0] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the rainfall data for that day\n");

            rainfallData[1, 0] = Console.ReadLine();

            // First day and it's rainfall data END

            // Second day and it's rainfall data
            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter a second day of the week\n");

            rainfallData[0, 1] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the rainfall data for that day\n");

            rainfallData[1, 1] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            // Second day and it's rainfall data END

            // Third day and it's rainfall data

            Headers(fontColor, "\nPlease enter a third day of the week\n");

            rainfallData[0, 2] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the rainfall data for that day\n");

            rainfallData[1, 2] = Console.ReadLine();

            // Third day and it's rainfall data END

            // Fourth day and it's rainfall data

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter a fourth day of the week\n");

            rainfallData[0, 3] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the rainfall data for that day\n");

            rainfallData[1, 3] = Console.ReadLine();

            // Fourth day and it's rainfall data END

            // Fifth day and it's rainfall data

            Headers(fontColor, "\nPlease enter a fifth days of the week\n");

            rainfallData[0, 4] = Console.ReadLine();

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nPlease enter the rainfall data for that day\n");

            rainfallData[1, 4] = Console.ReadLine();

            // Fifth day and it's rainfall data END

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nYou wrote the following data:\n");

            WriteLine(rainfallData[0, 0]);
            WriteLine(rainfallData[1, 0] + "\n");
            WriteLine(rainfallData[0, 1]);
            WriteLine(rainfallData[1, 1] + "\n");
            WriteLine(rainfallData[0, 2]);
            WriteLine(rainfallData[1, 2] + "\n");
            WriteLine(rainfallData[0, 3]);
            WriteLine(rainfallData[1, 3] + "\n");
            WriteLine(rainfallData[0, 4]);
            WriteLine(rainfallData[1, 4] + "\n");

            //Sum

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nAll of the rainfall data values, add up to:\n");

            double rainSum = 0;
            double rainDataForSum;

            for (int j = 0; j < rainfallData.GetLength(1); j++)
            {
                int i = 1;
                Double.TryParse(rainfallData[i, j], out rainDataForSum);
                rainSum = (rainDataForSum + rainSum);
            }

            WriteLine(rainSum + "\n");

            // Avg

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nAll of the rainfall data values, average up to:\n");

            double rainAvg;

            rainAvg = (rainSum / rainfallData.GetLength(1));

            WriteLine(rainAvg + "\n");

            // Lowest Value

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nFrom all of the rainfall data values, the lowest value is:\n");

            double lowestValueRainFall;

            Double.TryParse(rainfallData[1, 0], out lowestValueRainFall);


            for (int j = 0; j < rainfallData.GetLength(1); j++)
            {
                int i = 1;
                double rainfallDataDouble;
                Double.TryParse(rainfallData[i, j], out rainfallDataDouble);

                if (rainfallDataDouble < lowestValueRainFall)
                {

                    lowestValueRainFall = rainfallDataDouble;

                }
            }

            WriteLine(lowestValueRainFall + "\n");

            // Highest Value

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nFrom all of the rainfall data values, the highest value is:\n");

            double highestValueRainFall;

            Double.TryParse(rainfallData[1, 0], out highestValueRainFall);

            for (int j = 0; j < rainfallData.GetLength(1); j++)
            {
                int i = 1;
                double rainfallDataDouble;
                Double.TryParse(rainfallData[i, j], out rainfallDataDouble);

                if (rainfallDataDouble > highestValueRainFall)
                {

                    highestValueRainFall = rainfallDataDouble;

                }
            }

            WriteLine(highestValueRainFall + "\n");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThe Following is a demonstration of a jagged array:\n");

            byte[][] jaggedArray = new byte[2][];

            jaggedArray[0] = new byte[2] { 100, 200 };
            jaggedArray[1] = new byte[4] { 30, 40, 50, 60 };

            fontColor = ConsoleColor.White;


            Headers(fontColor, "\nThe jagged Array, Allows me to have more values on the second array than on the first array. Which we see here as one only has 2 values (top array) while the other one has 4 values (bottom array)\n");

            WriteLine("jaggedArray[0][0] = " + jaggedArray[0][0]);
            WriteLine("jaggedArray[0][1] = " + jaggedArray[0][1] + "\n");

            WriteLine("\n ------> (Beginning of second array).");
            WriteLine("jaggedArray[1][0] = " + jaggedArray[1][0]);
            WriteLine("jaggedArray[1][1] = " + jaggedArray[1][1]);
            WriteLine("jaggedArray[1][2] = " + jaggedArray[1][2]);
            WriteLine("jaggedArray[1][3] = " + jaggedArray[1][3] + "\n");

            fontColor = ConsoleColor.White;

            Headers(fontColor, "\nThank you for running Program02\n");

            ForegroundColor = ConsoleColor.Yellow;
            // u221E is the Unicode for infinity though you should not 
            // have an infinity number of requirements:)

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