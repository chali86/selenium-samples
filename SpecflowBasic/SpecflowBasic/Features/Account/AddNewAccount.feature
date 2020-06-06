Feature: AddNewAccount
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add new account
	Given I am in the guru page
	And i logged as the manager
	When I navigate to the new account
	Then create new account successfully
