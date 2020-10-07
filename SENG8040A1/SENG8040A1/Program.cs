using System;

namespace SENG8040A1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }
        public static void RunApp()
        {
            Console.WriteLine("Select a menu using number. \n" +
                "1. Enter triangle dimensions \n" +
                "2. Exit");

            int selectedMenu = GetMenu();
            while (selectedMenu != 1 && selectedMenu != 2)
            {
                Console.WriteLine("Enter only exsiting menu numbers.");
                Console.WriteLine("---------------------------------------\n" +
                    "Select a menu using number. \n" +
                    "1. Enter triangle dimensions \n" +
                    "2. Exit");
                selectedMenu = GetMenu();
            }

            if (selectedMenu == 1)
            {
                Console.WriteLine("---------------------------------------\n" +
                    "selected 1");
                GetTriangle();
                RunApp();
            }
            else if (selectedMenu == 2)
            {
                Console.WriteLine("---------------------------------------\n" +
                    "selected 2");
                Environment.Exit(0);
            }
        }
        public static int GetMenu()
        {
            int number;
            string input = Console.ReadLine();
            while (int.TryParse(input, out int x) == false)
            {
                Console.WriteLine("It is Invalid type. Enter only number.");
                Console.WriteLine("---------------------------------------\n" +
                    "Select a menu using number. \n" +
                    "1. Enter triangle dimensions \n" +
                    "2. Exit");
                input = Console.ReadLine();
            }
            number = Int32.Parse(input);
            return number;
        }
        public static void GetTriangle()
        {
            Console.WriteLine("Enter first side.");
            int firstSide = GetInput();

            Console.WriteLine("Enter second side.");
            int secondSide = GetInput();

            Console.WriteLine("Enter thrid side.");
            int thirdSide = GetInput();

            string result = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            Console.WriteLine($"\nEntered triangle dimensions are {firstSide}, {secondSide}, and {thirdSide}.");

            if (result.Contains("The valid triangle"))
            {
                Console.WriteLine($"RESULT: {result}\n");
            }
            else
            {
                Console.WriteLine($"RESULT: {result}\n" +
                    "*The sum of first and second side must be greater than third side.\n");
            }
            
        }
        public static int GetInput()
        {
            int number;
            string input = Console.ReadLine();
            while (int.TryParse(input, out int x) == false)
            {
                Console.WriteLine("It is Invalid type. Enter only number.");
                input = Console.ReadLine();
            }
            number = Int32.Parse(input);
            return number;
        }
    }
}
