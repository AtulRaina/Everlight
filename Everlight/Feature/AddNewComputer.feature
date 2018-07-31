Feature: AddNewComputer
Add new Computer 

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
      | Field            | Value      | 
      | Name             | Robo cop   | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I Click Create this Button
     Then New Computer is added 
  
  
  
  Scenario: User can not add computer with empty name
    Given I am on home page 
      And I click Add New Computer
      And  I add details of computer
      | Field            | Value      | 
      | Name             |            | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I Click Create this Button
     Then Message with Text Required is displayed 
      And Computer name text box is selected 
  
  
  Scenario: User can not add computer with Invalid Date format
    Given I am on home page 
      And I click Add New Computer
      And  I add details of computer
      | Field            | Value      | 
      | Name             | Robo cop   | 
      | IntroducredDate  | 12-12-1945 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I Click Create this Button
     Then Invalid date text box is higligted
  
   @Insert
  Scenario: Newly added comptuer information is saved correctly 
    Given I am on home page 
      And I click Add New Computer
      And  I add details of computer
      | Field            | Value      | 
      | Name             | Robo cop   | 
      | IntroducredDate  | 1902-12-12 | 
      | DiscontinuedDate | 1902-12-12 | 
      | Company          | IBM        | 
     When I Click Create this Button
     Then Computer Information is saved correctly
  
   @Insert
  Scenario: Newly added computer without dates is saved correctly 
    Given I am on home page 
      And I click Add New Computer
      And  I add details of computer
      | Field            | Value    | 
      | Name             | Robo cop | 
      | IntroducredDate  |          | 
      | DiscontinuedDate |          | 
      | Company          | IBM      | 
     When I Click Create this Button
     Then Computer Information is saved correctly
  
  
  
