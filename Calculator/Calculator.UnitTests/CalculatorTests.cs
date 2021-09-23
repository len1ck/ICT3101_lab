using NUnit.Framework;
using System;

namespace Calculators.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        // Qn 14
        [Test]
        public void Sub_WhenSubtractingEdgeNumber_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(100, -20);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void Mul_WhenMultiplyingWithZero_ResultLesserOrEqualsToZero()
        {
            // Act
            double result = _calculator.Multiply(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        [TestCase(-5, 5)]
        [TestCase(5, -5)]
        public void Mul_WhenMultiplyingWithNegativeValues_ResultIsNegative(double a, double b)
        {
            // Act
            double result = _calculator.Multiply(a, b);
            // Assert
            Assert.That(result, Is.Negative);
        }
        [Test]
        public void Mul_WhenMultiplyingTwoNegativeNumbers_ResultInPositiveNumber()
        {
            // Act
            double result = _calculator.Multiply(-5, -5);
            // Assert
            Assert.That(result, Is.Positive);
        }
        [Test]
        public void Div_WhenDividingZeroByNumber_ResultIsZero()
        {
            Assert.That(() => _calculator.Divide(0, 10), Is.EqualTo(0));
        }

        [Test]
        public void Div_WhenDividingByZero_ResultException()
        {
            Assert.That(() => _calculator.Divide(10, 0), Throws.ArgumentException);
        }

        // Qn 15
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b) {
            if (b == 0)
            {
                // Act and Assert
                Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            }
            else if(a == 0){
                // Act and Assert
                Assert.That(() => _calculator.Divide(a, b), Is.EqualTo(0));
            }
        }

        // Qn 16
        [Test]
        [TestCase(0)]
        public void Factorial_WithNormalZeroAndNegativeNumbers_ResultReturnOneIfInputZero(int a)
        {
            // Act and Assert
            Assert.That(() => _calculator.Factorial(a), Is.EqualTo(1));
        }

        [Test]
        [TestCase(-5)]
        public void Factorial_WithNormalZeroAndNegativeNumbers_ResultThrowArgumentExceptionIfNegative(int a)
        {
                // Act and Assert
                Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }


        // triangle
        [Test]
        [TestCase(-5,10)]
        [TestCase(5, -10)]
        [TestCase(5, 0)]
        [TestCase(0, 5)]
        public void AreaOfTriangl_WithNegativeNumberOrZero_ResultThrowArgumentException(int a,int b)
        {
            // Act and Assert
            Assert.That(() => _calculator.AreaOfTriangle(a,b), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfTriangle_WithValidInputs_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaOfTriangle(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(12.5));
        }
        // Triangle End

        // Circle
        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void AreaOfCircle_WithInvalidInputs_ResultThrowNewArgumentException(int a)
        {
            // Assert
            Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfCircle_WithValidInputs_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaOfCircle(5);
            // Assert
            Assert.That(result, Is.EqualTo(78.539816339744831));
        }
        // Circle End

        // Function A
        [Test]
        public void FactorialCounter_FunctionA_WhenGivenTestSameNumbers_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void FactorialCounter_FunctionA_WhenGivenTest5and4_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void FactorialCounter_FunctionA_WhenGivenTest5and3_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void FactorialCounter_FunctionA_WhenGivenTestNegativeFirstNumber_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.FactorialCounter_FunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void FactorialCounter_FunctionA_WhenGivenTestSecondNumberBiggerThanFirst_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.FactorialCounter_FunctionA(4, 5), Throws.ArgumentException);
        }


        // Function B
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.FactorialCounter_FunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.FactorialCounter_FunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.FactorialCounter_FunctionB(4, 5), Throws.ArgumentException);
        }
    }
}