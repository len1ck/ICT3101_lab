using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Calculators.UnitTests.Step_Definitions
{

    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private double _result;
        private readonly CalculatorData calculatorData;
        public UsingCalculatorDivisionsSteps(CalculatorData calculatorData)
        {
            this.calculatorData = calculatorData;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = calculatorData._calculator.Divide2(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(int.MaxValue));
        }
    }
}
