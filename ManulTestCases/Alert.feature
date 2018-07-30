Feature: Alerts
In order to avoid silly mistakes
As a math idiot
I want to be told the sum of two numbers

@mytag
  Scenario: Click on JS Alert Button and Select Ok 
    Given I am on Java Script Alert page
      And I click on Alert Button
     When I click Ok Button In Alert Window
     Then Message You successfuly clicked an alert is displayed 
  
  
  Scenario: Click on JS Confirm Button and Select Ok
    Given I am on Java Script Alert page
      And I click on JsComfirmButton
     When I click Ok Button In Alert Window
     Then Message You clicked: Ok is displayed 
  
  Scenario: Click on JS Confirm Button and Select Cancel
    Given I am on Java Script Alert page
      And I click on JsComfirmButton
     When I click Cancel Button In Alert Window
     Then Message You clicked: Cancel is displayed 
  
  
  
  Scenario: Click On JS Prompt Button ,Enter Text and Select OK
    Given I am on Java Script Alert page
      And I click on JsPromptButton
      And I send Text SampleText
     When I click Ok Button In Alert Window
     Then Message You entered: SampleText is displayed
  
  Scenario: Click On JS Prompt Button ,Enter Text and Select Cancel
    Given I am on Java Script Alert page
      And I click on JsPromptButton
      And I send Text SampleText
     When I click Cancel Button In Alert Window
     Then Message You entered: null is displayed
  
  Scenario: Click On JS Prompt Button and Select Cancel
    Given I am on Java Script Alert page
      And I click on JsPromptButton
     When I click Cancel Button In Alert Window
     Then Message You entered: null is displayed
  
  
  Scenario: Play All Buttons
    Given I am on Java Script Alert page
      And I click on Alert Button
     When I click Ok Button In Alert Window
     Then Message You successfuly clicked an alert is displayed 
    Given I click on JsComfirmButton
     When I click Ok Button In Alert Window
     Then Message You clicked: Ok is displayed 
    Given I click on JsPromptButton
      And I send Text SampleText
     When I click Ok Button In Alert Window
     Then Message You entered: SampleText is displayed
    Given I click on JsPromptButton
     When I click Cancel Button In Alert Window
     Then Message You entered: null is displayed
    Given I click on JsComfirmButton
     When I click Cancel Button In Alert Window
     Then Message You clicked: Cancel is displayed 
