Feature: Alerts
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Alert Window Message
	Given I am on Java Script Alert page
	And I click on Alert Button
	When I click Ok Button In Alert Window
	Then Message You successfuly clicked an alert is displayed 


	Scenario: Confirm Window Click
	Given I am on Java Script Alert page
	And I click on JsComfirmButton
	When I click Ok Button In Alert Window
	Then Message You clicked: Ok is displayed 


	Scenario: Prompt Window Click
	Given I am on Java Script Alert page
	And I click on JsPromptButton
	And I send Text SampleText
	When I click Ok Button In Alert Window
	Then Message You entered: SampleText is displayed