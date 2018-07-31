Feature: HomePage
Search for computer

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
     Then  Number of Filtred Computers are displayed Correctly <number>
    Examples: 
      | FilterComputer | number | 
      | ASCI           | 6      | 
      | IBM            | 25     | 
      | APPLE          | 13     | 
  #please note the number may change test is brittle 
  
  
  
