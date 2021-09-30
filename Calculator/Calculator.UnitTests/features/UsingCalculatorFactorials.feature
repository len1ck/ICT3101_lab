Feature: UsingCalculatorFactorials
In order to conquer factorials
As a factorial enthusiast
I want to understand a variety of factorial operations

@Factorials
Scenario: factorial of five
	Given I have a calculator
	When  I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"

@Factorials
Scenario: factorial of zero
	Given I have a calculator
	When  I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"