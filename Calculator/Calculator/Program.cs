using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
                bool endApp = false;
                Calculator _calculator = new Calculator();
                // Display title as the C# console calculator app.
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");
                while (!endApp)
                {
                    double result = 0;
                    // Ask the user to choose an operator.
                    Console.WriteLine("Choose an operator from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.WriteLine("\tf - Factorial(First number as input)");
                    Console.WriteLine("\tdd - Defect Density");
                    Console.Write("Your option? ");
                    string op = Console.ReadLine();
                    try
                    {
                        result = _calculator.DoOperation(op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else if (result == int.MaxValue - 1) {
                     
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Oh no! An exception occurred trying math .\n - Details: " + e.Message);
                    }
                    Console.WriteLine("------------------------\n");
                    // Wait for the user to respond before closing.
                    Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "q") endApp = true;
                    Console.WriteLine("\n"); // Friendly linespacing.
                }
                return;
        }
    }
}
