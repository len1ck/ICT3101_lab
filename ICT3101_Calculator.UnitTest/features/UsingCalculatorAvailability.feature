Feature: UsingCalculatorAvailability
 In order to calculate MTBF and Availability
 As someone who struggles with math
 I want to be able to use my calculator to do this
@Availability
Scenario: Calculating MTBF
 Given I have a calculator
 #MTTF+MTTR=MTBF
 When I have entered "100" and "50" into the calculator and press MTBF
 Then the availability result should be "150"
@Availability
Scenario: Calculating Availability
 Given I have a calculator
 #MTTF/MTBF
 When I have entered "100" and "150" into the calculator and press Availability
 Then the availability result should be "0.67"
 @Availability
Scenario: Calculating MTTR
 Given I have a calculator
 #MTBF-MTTF=MTTR
 When I have entered "150" and "100" into the calculator and press MTTR
 Then the availability result should be "50"
