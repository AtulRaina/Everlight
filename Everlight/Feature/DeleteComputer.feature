Feature: DeleteComputer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Delete
Scenario: Computer Can be deleted
	Given  I am at home page 
	And   I Filter computer with Robo cop
	And  I select the computer
	When  I Click Delete
	Then the computer is deleted 
