using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Calculators.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private double _result;
        //private readonly CalculatorData calculatorData;
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorDefectDensitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"" as the total defect and ""(.*)"" as the updated KSSI into the calculator and press defect density")]
        public void WhenIHaveEnteredAsTheTotalDefectAndAsTheUpdatedKSSIIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" as the current KSSI and ""(.*)"" as the KCSI and ""(.*)"" as the lines of changed code and ""(.*)"" as the lines of deleted code into the calculator and press updated KSSI")]
        public void WhenIHaveEnteredAsTheCurrentKSSIAndAsTheKCSIAndAsTheLinesOfChangedCodeAndAsTheLinesOfDeletedCodeIntoTheCalculatorAndPressUpdatedKSSI(double p0, double p1, double p2, double p3)
        {
            _result = _calculator.UpdatedKSSI(p0, p1, p2, p3);
        }
        
        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the updated KSSI result should be ""(.*)""")]
        public void ThenTheUpdatedKSSIResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
