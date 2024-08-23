using System;
using System.Data;
using System.Linq.Expressions;
using System.Numerics;
//this is the simple example of calculator using C# with proper error handling and basic requirements of calc,
class Program
{



    class calc()
    {
        private double a;
        private double b;
        private string command;



        public void menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number a:");
                    a = Convert.ToDouble(Console.ReadLine());
                }

                catch(FormatException){
                    Console.WriteLine("Enter value is not number.");
                    continue;
                }
                try
                {
                    Console.WriteLine("Enter second number b:");

                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter value is not number.");
                    continue;


                }
                Console.WriteLine("What would you like to do ?\n For addition enter A, for division D multiply M and for substract S");
                Console.WriteLine("Press X to exit.");
                command = Console.ReadLine().ToLower();
                if (command == "x")
                {
                    break;
                }
                else if (command != "x")
                {

                    operation();
                }

            }
        }
        void again()
        {
            Console.WriteLine("Would you like to try again? \n Enter Y to continue X to exit.");
            command = Console.ReadLine().ToLower();
            if (command == "y")
            {
                menu();
            }else if (command == "x") {
                Environment.Exit(0); // Exit the program immediately
                

            }
        }
    
        public void operation()
        {
            try
            {


                switch (command)
                {
                    case "a":
                        Console.WriteLine($"Result of addition: {Add(a, b)}");
                        break;
                    case "m":
                        Console.WriteLine($"Result of multiply : {multiply(a, b)}");
                        break;
                    case "s":
                        Console.WriteLine($"Result of substraction is: {subtract(a, b)}");
                        break;
                    case "d":
                        Console.WriteLine($"Result of the division is {divide(a, b)}");
                        break;

                    default:
                        Console.WriteLine("invalid entry try again.");

                        break;

                }
                again();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }


        public double Add(double a, double b)
        {
            return a + b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allow");

            }
            else
            {
                return a / b;
            }
        }


        static void Main(String[] args)
        {
            calc c = new calc();
            c.menu();
        }
    }
}
