Feature: Update
Update computer information
#Must add a comptuer update it and delete it 	
@Update  
  Scenario: Computer Information is Updated 
    Given Computer with name Robo Cop already exist
      And  I select Computer with Name Robo Cop
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1986-12-12   | 
      | DiscontinuedDate | 1600-12-12   | 
      | Company          | APPLE        | 
     When I click save Computer
     Then Computer information Is Updated
    Given  I select Computer with Name TestComputer
      And I have Enter the details 
      | Field            | Value      | 
      | Name             | Robo Cop   | 
      | IntroducredDate  | 2018-12-12 | 
      | DiscontinuedDate | 2019-12-12 | 
      | Company          | IBM        | 
     When I click save Computer
     Then Computer information Is Updated
      And I Delete the computer with Robo Cop
  @Update
  Scenario: Computer Name is Updated and Saved 
    Given Computer with name Robo Cop already exist
      And  I select Computer with Name Robo Cop
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1986-12-12   | 
      | DiscontinuedDate | 1600-12-12   | 
      | Company          | Apple Inc.   | 
     When I click save Computer
     Then  Computer Name is saved correctly
  
  @Update
  Scenario: Computer Introduced Date is Updated and Saved 
    Given Computer with name Robo Cop already exist
      And  I select Computer with Name Robo Cop
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1986-12-12   | 
      | DiscontinuedDate | 1600-12-12   | 
      | Company          | APPLE        | 
     When I click save Computer
     Then Computer Introduced date is saved correctly
  @Update
  Scenario: Computer Discontinued Date is Updated and Saved 
    Given Computer with name Robo Cop already exist
      And  I select Computer with Name Robo Cop
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1986-12-12   | 
      | DiscontinuedDate | 1600-12-12   | 
      | Company          | APPLE        | 
     When I click save Computer
     Then Computer Discontinued Date is saved Correctly
  
  @Update
  Scenario: Computer Company Name is Updated and Saved 
    Given Computer with name Robo Cop already exist
      And  I select Computer with Name Robo Cop
      And I have Enter the details 
      | Field            | Value        | 
      | Name             | TestComputer | 
      | IntroducredDate  | 1986-12-12   | 
      | DiscontinuedDate | 1600-12-12   | 
      | Company          | Apple Inc.   | 
     When I click save Computer
     Then Computer Company is saved correctly
