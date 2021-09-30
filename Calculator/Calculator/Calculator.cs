using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
         
            switch (op)
            {
                case "a":
                    // Declare variables and set to empty.
                    string numInput1 = "";
                    string numInput2 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    // Ask the user to type the second number.
                    Console.Write("Type another number, and then press Enter: ");
                    numInput2 = Console.ReadLine();
                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = Console.ReadLine();
                    }
                    result = Add(cleanNum1, cleanNum2);
                    return result;
                case "s":
                    // Declare variables and set to empty.
                    numInput1 = "";
                    numInput2 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    // Ask the user to type the second number.
                    Console.Write("Type another number, and then press Enter: ");
                    numInput2 = Console.ReadLine();
                    cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = Console.ReadLine();
                    }
                    result = Subtract(cleanNum1, cleanNum2);
                    return result;
                case "m":
                    // Declare variables and set to empty.
                    numInput1 = "";
                    numInput2 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    // Ask the user to type the second number.
                    Console.Write("Type another number, and then press Enter: ");
                    numInput2 = Console.ReadLine();
                    cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = Console.ReadLine();
                    }
                    result = Multiply(cleanNum1, cleanNum2);
                    return result;
                case "d":
                    // Declare variables and set to empty.
                    numInput1 = "";
                    numInput2 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    // Ask the user to type the second number.
                    Console.Write("Type another number, and then press Enter: ");
                    numInput2 = Console.ReadLine();
                    cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = Console.ReadLine();
                    }
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(cleanNum1, cleanNum2);
                    return result;
                case "f":
                    // Declare variables and set to empty.
                    numInput1 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    result = Factorial(cleanNum1);
                    return result;
                case "dd":
                    // Declare variables and set to empty.
                    numInput1 = "";
                    numInput2 = "";
                    string numInput3 = "";
                    string numInput4 = "";
                    // Ask the user to type the first number.
                    Console.Write("Type a number for the initial failure intensity, and then press Enter: ");
                    numInput1 = Console.ReadLine();
                    cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = Console.ReadLine();
                    }
                    // Ask the user to type the second number.
                    Console.Write("Type a number for the failure intensity decay parameter, and then press Enter: ");
                    numInput2 = Console.ReadLine();
                    cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = Console.ReadLine();
                    }
                    // Ask the user to type the third number.
                    Console.Write("Type a number for the average number of failures at time T, and then press Enter: ");
                    numInput3 = Console.ReadLine();
                    double cleanNum3 = 0;
                    while (!double.TryParse(numInput3, out cleanNum3))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput3 = Console.ReadLine();
                    }
                    // Ask the user to type the forth number.
                    Console.Write("Type a number for the given time, and then press Enter: ");
                    numInput4 = Console.ReadLine();
                    double cleanNum4 = 0;
                    while (!double.TryParse(numInput4, out cleanNum4))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput4 = Console.ReadLine();
                    }
                    result = FailureIntensityLog(cleanNum1, cleanNum2, cleanNum3);
                    double result2 = AverageFailureLog(cleanNum1, cleanNum2, cleanNum4);
                    Console.WriteLine("Your result for Logarithmic Failure Intensity: {0:0.##}\n", result);
                    Console.WriteLine("Your result for Average Failure Rate: {0:0.##}\n", result2);
                    return int.MaxValue -1;
                // Return text for an incorrect option entry.
                default:
                    return result;
            }
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double Add2(double num1, double num2)
        {
            if (10 > num1)
            {
                return (num2 + -4);
            }
            else if (10 == num1)
            {
                return (num2 + 0);
            }
            else {
                return (num2 + 4);
            }
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        // Question 15 Start
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new System.ArgumentException("zero");
            }
            return (num1 / num2);
        }

        public double Divide2(double num1, double num2)
        {
            if (num1 != 0 && num2 == 0)
            {
                return int.MaxValue;
            }
            else if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            else
            {
                return (num1 / num2);
            }
        }
        // Question 15 End

        // Question 16 Start
        public double Factorial(double num1)
        {
            if (num1 < 0)
            {
                throw new System.ArgumentException("less than zero");
            }
            if (num1 == 0)
            {
                return 1;
            }
            else
            {
                return num1 * Factorial(num1 - 1);
            }
        }
        // Question 16 End

        // Question 17 Start 
        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (0.5 * num1 * num2);
        }

        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return (Math.PI * num1 * num1);
        }
        // Question 17 End

        // Question 18 Start
        public double FactorialCounter_FunctionA(double num1, double num2)
        {
            if (num1 <= 0)
            {
                throw new System.ArgumentException("less than zero");
            }
            if (num2 <= 0)
            {
                throw new System.ArgumentException("less than zero");
            }
            if (num1 < num2)
            {
                throw new System.ArgumentException("lesser than");
            }
            else
            {
                double result1 = Subtract(num1, num2);
                double result2 = Factorial(result1);
                double result3 = Factorial(num1);
                double result4 = Divide(result3, result2);
                return result4;
            }
        }

        public double FactorialCounter_FunctionB(double num1, double num2)
        {
            if (num1 <= 0)
            {
                throw new System.ArgumentException("less than zero");
            }
            if (num2 <= 0)
            {
                throw new System.ArgumentException("less than zero");
            }
            if (num1 < num2)
            {
                throw new System.ArgumentException("lesser than");
            }
            else
            {   
                double result1 = Subtract(num1, num2); 
                double result2 = Factorial(result1); 
                double result3 = Factorial(num1); 
                double result4 = Factorial(num2); 
                double result5 = Multiply(result4,result2);
                double result6 = Divide(result3, result5);

                return result6;
            }
        }
        // Question 18 End

        public double MTBF(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double MTTR(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Availability(double num1, double num2)
        {
            double result = num1 / num2;
            return Math.Round(result, 2);
        }

        public double FailureIntensity(double num1, double num2, double num3)
        {
            double result = num1*(1-(num2/num3));
            return Math.Round(result, 2);
        }

        public double AverageFailure(double num1, double num2, double num3)
        {
            double result = num1 * (1 - Math.Exp(-(num2/num1)*num3));
            return Math.Round(result, 2);
        }

        public double FailureIntensityLog(double num1, double num2, double num3)
        {
            double result = num1 * Math.Exp(-(num2 * num3));
            return Math.Round(result, 2);
        }

        public double AverageFailureLog(double num1, double num2, double num3)
        {
            double result = (1/num2) * Math.Log(( num1 * num2 * num3)+1);
            return Math.Round(result, 2);
        }

        public double DefectDensity(double num1, double num2)
        {
            double result = num1 / num2;
            return Math.Round(result, 2);
        }

        public double UpdatedKSSI(double num1, double num2, double num3,double num4)
        {
            double result = num1 + num2 - num3 - num4;
            return Math.Round(result, 2);
        }
    }

}
