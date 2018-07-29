  Scenario Outline: Computer Can be filtered By name 
    Given I Navigate to Home page 
     When  I Enter search Term <FilterComputer>
      And   I click on Filter Button
     Then  Computer List is filtered with <FilterComputer>
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
     Then  Number of filtered Computers are displayed Correctly
    Examples: 
      | FilterComputer | 
      | ASCI           | 
      | IBM            | 
      | APPLE          | 
  
  
  Scenario: Filter results greater than 10
    Given I Navigate to Home page 
     When  I Enter search Term <FilterComputer>
      And   I click on Filter Button
     Then  Number of filtered Computers are displayed Correctly
     When I click on Next Button
     Then filtered results are displayed 
  