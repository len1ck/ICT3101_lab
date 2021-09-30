using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Calculators.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorLogReliabilitySteps
    {
        private double _result;
        //private readonly CalculatorData calculatorData;
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorLogReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"" as the initial failure intensity and ""(.*)"" as the failure intensity decay parameter and ""(.*)"" as the average number of failures at time T into the calculator and press current logarithmic failure intensity")]
        public void WhenIHaveEnteredAsTheInitialFailureIntensityAndAsTheFailureIntensityDecayParameterAndAsTheAverageNumberOfFailuresAtTimeTIntoTheCalculatorAndPressCurrentLogarithmicFailureIntensity(double p0, double p1, double p2)
        {
            _result = _calculator.FailureIntensityLog(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" as the initial failure intensity and ""(.*)"" as the failure intensity decay parameter and ""(.*)"" as the given time into the calculator and press logarithmic average number of failures")]
        public void WhenIHaveEnteredAsTheInitialFailureIntensityAndAsTheFailureIntensityDecayParameterAndAsTheGivenTimeIntoTheCalculatorAndPressLogarithmicAverageNumberOfFailures(double p0, double p1, double p2)
        {
            _result = _calculator.AverageFailureLog(p0, p1, p2);
        }
        
        [Then(@"the logarithmic failure intensity result should be ""(.*)""")]
        public void ThenTheLogarithmicFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the logarithmic average number of failure result should be ""(.*)""")]
        public void ThenTheLogarithmicAverageNumberOfFailureResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
