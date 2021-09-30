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
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Ask the user to enter a non-zero divisor.
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
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
    }

}
