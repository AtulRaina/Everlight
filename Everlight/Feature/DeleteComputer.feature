Feature: DeleteComputer
Delete Existing Computer

@Delete
  Scenario: Computer Can be deleted
    Given   I am at home page 
      And A computer with name Test Delete exist 
      And   I Filter computer with Test Delete
      And  I select the computer
     When  I Click Delete
     Then the computer is deleted 

	 @Delete
 Scenario: Multiple Computers can Be Deleted in the same session
    Given   I am at home page 
      And A computer with name JAVA exist 
	  And A computer with name PYTHON exist 
	  And A computer with name C# exist 
	  And A computer with name C++ exist
      And   I Filter computer with JAVA
      And  I select the computer
     When  I Click Delete
     Then the computer is deleted 
	 Given   I Filter computer with PYTHON
      And  I select the computer
     When  I Click Delete
     Then the computer is deleted 
	  Given   I Filter computer with C#
      And  I select the computer
     When  I Click Delete
     Then the computer is deleted 
	  Given   I Filter computer with C++
      And  I select the computer
     When  I Click Delete
     Then the computer is deleted 
  

