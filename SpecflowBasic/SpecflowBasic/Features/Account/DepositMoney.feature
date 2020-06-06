Feature: DepositMoney
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Deposite the money
	Given I am in the guru bank page 
	And I logged into manager account
	When I navigate to deposit
	Then i successfully deposit money
