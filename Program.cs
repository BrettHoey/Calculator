using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    continueCalculation = false;
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = Add(num1, num2);
                        break;
                    case "2":
                        result = Subtract(num1, num2);
                        break;
                    case "3":
                        result = Multiply(num1, num2);
                        break;
                    case "4":
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        continue;
                }

                Console.WriteLine($"The result is: {result}\n");
            }

            Console.WriteLine("Thank you for using the Calculator!");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }
}
