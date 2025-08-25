using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            char operation = ' ';
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Calculator app!\n");

                Console.WriteLine("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose an operation (+, -, *, /): ");
                operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("The result is: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation.");
                        return;
                }
                Console.WriteLine("Do you want to do another operation?");
                Console.WriteLine("Press Y to continue or N to exit.");

                char choice = Convert.ToChar(Console.ReadLine().ToUpper());
                if (choice == 'N')
                {
                    Console.WriteLine("Thank you for using the Calculator app. Goodbye!");
                    running = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
