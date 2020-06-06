Feature: EditExistingCustomer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Edit the customer
	Given I am in the guru home page
	And I logged as a manager
	When I navigate to edit customer
	Then I edit customer successfully
