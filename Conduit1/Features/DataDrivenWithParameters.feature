Feature: DataDrivenWithParameters
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameters
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter username text "Oyindamola"
	And I enter email text "folake.@talktalk.net"
	And I enter password text "PasswordSecured"
	And I click on sign up button
	#Then I am logged in with my username displayed
