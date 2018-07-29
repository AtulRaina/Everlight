Feature: DeleteComputer
In order to avoid silly mistakes
As a math idiot
I want to be told the sum of two numbers

@mytag
  Scenario: Delete an Existing computer
    Given  I am on home page 
      And I Enter computer name in filter box<computername> 
      And I click Filter button
      And I select the Computer 
     When I press the delete button 
     Then I am redirected to home page
      And message is displayed "ComputerName! Computer has been deleted "
  
  
  Scenario: Deleted Computer is not displayed in the search results
    Given  I am on home page 
      And I Enter computer name in filter box<computername> 
      And I click Filter button
      And I select the Computer 
     When I press the delete button 
      And I Enter computer name in filter box<computername> 
      And I click Filter button
     Then <computername> does not appear in search results
  
  
  Scenario: Multiple computers can be deleted 
    Given  I am on home page 
      And I Enter computer name in filter box<computername1> 
      And I click Filter button
      And I select the Computer 
     When I press the delete button 
     Then I am redirected to home page
      And message is displayed "ComputerName1! Computer has been deleted "
      And I Enter computer name in filter box<computername2> 
      And I click Filter button
      And I select the Computer 
     When I press the delete button 
     Then I am redirected to home page
      And message is displayed "ComputerName2! Computer has been deleted "
  
