using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Calculators.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private double _result;
        private readonly CalculatorData calculatorData;
        public UsingCalculatorAdditionsSteps(CalculatorData calculatorData) 
        {
            this.calculatorData = calculatorData;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculatorData._calculator = new Calculator();
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = calculatorData._calculator.Add2(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }

    public class CalculatorData // the POCO for sharing person data
    {
        public Calculator _calculator;
    }
}
