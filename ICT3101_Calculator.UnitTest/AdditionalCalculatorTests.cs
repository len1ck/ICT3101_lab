using Calculators;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTest
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read(@"../../../MagicNumbers.txt")).Returns(new string[4] { "15", "10", "30", "5" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(1, 20)]
        [TestCase(3, 10)]
        public void FileReaderFunction_WhenGiven1_returnIndexOneofString(double a, double b)
        {
            // Act
            double result = _calculator.GenMagicNum(a, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }
    }
}
