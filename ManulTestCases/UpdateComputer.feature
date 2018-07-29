  Scenario: Computer Information is Updated 
    Given I am at home page
      And  I select Computer with Name <Testname>
      And I Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1902-12-12   | 
      | DiscontinuedDate | 1902-12-12   | 
      | Company          | IBM          | 
     When I click save Computer
     Then Computer information Is Updated message is displayed
  
  Scenario: Computer Information is Updated in filter
    Given I am at Home Page
      And  I select Computer with Name <Testname>
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1902-12-12   | 
      | DiscontinuedDate | 1902-12-12   | 
      | Company          | IBM          | 
     When I click save Computer
     Then I am redirected to home page
      And   I Filter computers with name <Testname>
     Then  no records are returned 
     When  I Filter computer with name TestComputer
     Then Computer information saved earlier is displayed.
  
  
  
  Scenario: Computer name is updated
    Given I am at home page
      And   I filter computer with name <Testname>
      And   I select the computer
      And   I Update comptuer name to “New Name”
     When  I click save 
     Then   Computer information is update
     When I filter computer with name  “New name” 
  The   Only computer name is updated 
  
  Scenario: Computer Brand is updated
    Given I am at home page
      And   I filter computer with name <Testname>
      And   I select the computer
      And   I Update Brand to “New Name”
     When  I click save 
     Then   Computer information is update
     When I filter computer with name  <Testname>
     Then   Only computer brand is updated 
  
  
  
  
  
  
  Scenario: Discontinued date is updated
    Given I am at home page
      And   I filter computer with name <Testname>
      And   I select the computer
      And   I Update Discontinued date to “New date”
     When  I click save 
     Then   Computer information is update
     When I filter computer with name  <Testname>
     Then   Only computer Discontinued date is updated 
  
  
  
  Scenario: Introduced date is updated
    Given I am at home page
      And   I filter computer with name <Testname>
      And   I select the computer
      And   I Update Introduced date to “New date”
     When  I click save 
     Then   Computer information is update
     When I filter computer with name  <Testname>
     Then   Only computer Introducred date is updated 
  
  
  Scenario: Computer Information is not updated when correct information
    Given I am at Home Page
      And  I select Computer with Name <Testname>
      And I have Enter the details 
      | Field            | Value      | 
      | Name             |            | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I click save Computer
     Then Empty name message is displayed 
      And I navigate to home page 
      And   I Filter computers with name <Testname>
     Then  Computer Information is not updated
  