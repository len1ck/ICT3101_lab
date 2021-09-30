Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario: Calculate Current Failure Intensity
	Given I have a calculator
	When I have entered "50" as the initial failure intensity and "60" as the average number of failures and "400" as the total number of failures over an infinite time into the calculator and press current failure intensity
	Then the failure intensity result should be "42.5"

@BasicReliability
Scenario: Calculate Average Number of Expected Failures
	Given I have a calculator
	When I have entered "400" as the total number of failures over an infinite time and "50" as the initial failure intensity and "5" as the given time into the calculator and press average number of failures
	Then the average number of failure result should be "185.90"