Feature: HomePage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Filter
Scenario Outline: Computer Can be filtered By name 
	Given I Navigate to Home page 
	When  I Enter search Term <FilterComputer>
	And   I click on Filter Button
	Then  Computer List is filtred with <FilterComputer>
	Examples: 
	| FilterComputer |
	| ASCI           |
	| IBM            |
	| APPLE          |

@Filter
Scenario Outline: Number of Filtered Computers are displayed correctly
	Given I Navigate to Home page 
	When  I Enter search Term <FilterComputer>
	And   I click on Filter Button
	Then  Number of Filtred Computers are displayed Correctly
	Examples: 
	| FilterComputer |
	| ASCI           |
	| IBM            |
	| APPLE          |