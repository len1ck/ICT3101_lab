#As a Software Quality Metric enthusiast
#I want to use my calculator to do this
#So that I can calculate the Defect Density of the system
Feature: UsingCalculatorDefectDensity
In order to calculate the Defect Density of the system
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator
	When I have entered "50" as the total defect and "100" as the updated KSSI into the calculator and press defect density
	Then the defect density result should be "0.5"

@DefectDensity
Scenario: Calculate Kilo Source Shipped Instructions(KSSI)
	Given I have a calculator
	When I have entered "50" as the current KSSI and "30" as the KCSI and "14" as the lines of changed code and "5" as the lines of deleted code into the calculator and press updated KSSI
	Then the updated KSSI result should be "61"