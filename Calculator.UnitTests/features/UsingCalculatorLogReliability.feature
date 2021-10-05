#As a Software Quality Metric enthusiast
#I want to use my calculator to do this
#So that I can calculate the Logarithmic Musa model's failures/intensities
Feature: UsingCalculatorLogReliability
In order to calculate the Logarithmic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@LogReliability
Scenario: Calculate Current Logarithmic Failure Intensity
	Given I have a calculator
	When I have entered "50" as the initial failure intensity and "0.01" as the failure intensity decay parameter and "60" as the average number of failures at time T into the calculator and press current logarithmic failure intensity and "5" as the given time into the calculator and press logarithmic average number of failures
	Then the logarithmic failure intensity result should be "27.44" and the logarithmic average number of failure result should be "125.28"