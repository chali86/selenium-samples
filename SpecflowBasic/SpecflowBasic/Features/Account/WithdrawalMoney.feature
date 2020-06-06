Feature: WithdrawalMoney
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: WithdrawalMoney
	Given I am in the guru login page
	And I logged into manager profile
	When I navigate to withdrawal
	Then I successfully withdrawal money
