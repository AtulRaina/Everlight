Feature: Update
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@Update
Scenario: Computer Information is Updated 
	Given I select a Computer from Home Page
	And  I select Computer with Name <Testname>
	And I have Enter the details 
	| Field              | Value       |
	| Name               | TestComputer|
	| IntroducredDate    | 1902-12-12  |
	| DiscontinuedDate   | 1902-12-12  |
	| Company            | IBM         |
	When I click save Computer
	Then Computer information Is Updated
