Feature: CustomerRegistration
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create new customer
	Given Im in the guru bank page
	And I logged as manager
	When I navigate to new customer
	Then create a new customer successfully
