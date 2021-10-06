using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Calculators.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private double _result;
        //private readonly CalculatorData calculatorData;
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"" as the initial failure intensity and ""(.*)"" as the average number of failures and ""(.*)"" as the total number of failures over an infinite time into the calculator and press current failure intensity")]
        public void WhenIHaveEnteredAsTheInitialFailureIntensityAndAsTheAverageNumberOfFailuresAndAsTheTotalNumberOfFailuresOverAnInfiniteTimeIntoTheCalculatorAndPressCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.FailureIntensity(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" as the total number of failures over an infinite time and ""(.*)"" as the initial failure intensity and ""(.*)"" as the given time into the calculator and press average number of failures")]
        public void WhenIHaveEnteredAsTheTotalNumberOfFailuresOverAnInfiniteTimeAndAsTheInitialFailureIntensityAndAsTheGivenTimeIntoTheCalculatorAndPressAverageNumberOfFailures(int p0, int p1, int p2)
        {
            _result = _calculator.AverageFailure(p0, p1, p2);
        }
        
        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the average number of failure result should be ""(.*)""")]
        public void ThenTheAverageNumberOfFailureResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
