Feature: Registration
	In order to use the angularjs website
	I will need to register
	So that I can share my expert knowledge.

@mytag
Scenario: Valid Registration
	Given I navigate to angularjs website
	When I click on Sign up
	And I enter my username
	And I enter my email
	And I enter my password
	And I sign up on registration page
	#Then my account should be created
