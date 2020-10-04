using System;

namespace SENG8040A1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProg();
        }
        public static void RunProg()
        {
            Console.WriteLine("Select a menu using number. \n" +
                "1. Enter triangle dimensions \n" +
                "2. Exit");

            int selectedMenu = GetInput();
            while (selectedMenu != 1 && selectedMenu != 2)
            {
                Console.WriteLine("Enter only exsiting menu numbers.");
                selectedMenu = GetInput();
            }

            if (selectedMenu == 1)
            {
                Console.WriteLine("selected 1. Enter triangle dimensions");
                GetTriangle();
                Restart();
            }
            else if (selectedMenu == 2)
            {
                Console.WriteLine("selected 2. Exit");
                Environment.Exit(0);
            }
        }
        public static void Restart()
        {
            Console.WriteLine("Would you like to restart the program? If so, enter 'y'.");
            string restartInput = Console.ReadLine().ToLower();
            if (restartInput == "y")
            {
                RunProg();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static void GetTriangle()
        {
            Console.WriteLine("Enter first dimension.");
            int firstD = GetInput();

            Console.WriteLine("Enter second dimension.");
            int secondD = GetInput();

            Console.WriteLine("Enter thrid dimension.");
            int thridD = GetInput();

            TriangleSolver triangleSolver = new TriangleSolver();
            triangleSolver.Analyze(firstD, secondD, thridD);
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
