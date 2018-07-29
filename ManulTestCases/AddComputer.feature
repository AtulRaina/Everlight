  Scenario: Add New computer page is displayed
    Given I Navigate to Home page
     When I click add computer
     Then add new computer page is displayed
  
  
  
  Scenario: New computer can be added
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details
      | Field            | Value      | 
      | Name             | Robo cop   | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I  click update computer
     Then  I am redirected to Home Page
      And   Message  Is displayed .
  
  Scenario: Computer is not added when Computer Name is blank
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details
      | Field            | Value      | 
      | Name             |            | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I  click update computer
     Then  Computer is not saved 
      And  Enter computer name Message is displayed 
  
  
  Scenario: Computer is not added With Invalid Date format
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details
      | Field            | Value      | 
      | Name             | Robo cap   | 
      | IntroducredDate  | 12-12-1902 | 
      | DiscontinuedDate | 12-12-1902 | 
      | Company          | IBM        | 
     When I  click update computer
     Then  Computer is not saved 
      And  Enter valid date message is displayed  
  
  
  
  Scenario Outline: Invalid Computer Information
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details <Name><Introduced Date> <Discontinued Date> <Company>
     When I  click update computer
     Then  Computer is <Added Status>
    Examples: 
      | Name | Introducred Date | Discontinued Date | Company | Added Status | 
      |      |                  |                   |         | False        | 
      | Test | 12-12-1902       |                   | IBM     | False        | 
  
  Scenario Outline: Date Introduced is greater than discontinued
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details <Name><Introduced Date> <Discontinued Date> <Company>
     When I  click update computer
     Then  Computer is <Added Status>
    Examples: 
      | Name      | Introducred Date | Discontinued Date | Company | Added Status | 
      | TestComp1 | 2018-12-12       | 2018-12-11        | IBM     | False        | 
  
  Scenario: Computer Information is saved correctly 
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details
      | Field            | Value      | 
      | Name             | Comp1      | 
      | IntroducredDate  | 1902-12-11 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I  click update computer
     Then  I am redirected to Home Page
      And   Success Message  Is displayed .
     When I filter computer with the name Comp1
     Then correct Computer name is displayed as Comp1
      And   IntroducedDate is displayed correct
      And discontinued date is displayed correct
      And Company is displayed correct
  
  
  
  
  Scenario: Press cancel button to the original page
    Given I Navigate to Home page
      And  I click add Computer
      And I  add Computer details
      | Field            | Value      | 
      | Name             | Comp1      | 
      | IntroducredDate  | 1902-12-11 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I click Cancel 
     Then I am redirect to Home page
      And Computer Information is not saved.
  