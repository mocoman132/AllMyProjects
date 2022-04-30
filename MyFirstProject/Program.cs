// MyFirstProject.cs

using System;

namespace MyFirstProject
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You entered the following {0} names " + "on the command line:", args.Length);
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to proceed.");
            Console.ReadKey(true);
        }
    }
}
