Feature: AddNewComputer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Insert
Scenario: Add new Computer Page is displayed
	Given I am on home page 
	When I click Add New Computer
	Then  Add new Computer page is displayed
@Insert
Scenario: New computer can be added 
	Given I am on home page 
	And I click Add New Computer
	And  I add details of computer
	| Field              | Value      |
	| Name               | Robo cop   |
	| IntroducredDate    | 1902-12-12 |
	| DiscontinuedDate   | 1902-12-12 |
	| Company            | IBM        |
	When I Click Create this Button
	Then New Computer is added 