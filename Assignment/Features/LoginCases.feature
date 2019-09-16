Feature: Sign in Functionality

@mytag
Scenario Outline: Sign in with given email and password
   Given I am on the home page 
   When I clicks on SignIn button
   And I enters username as <username> and password as <password>	
   And I click on SignIn button
   Then I should see <errorMessage>
      Examples: 
   | username           | password | errorMessage               |
   |                    |          | An email address required. |
   |                    | abcdef   | An email address required. |
   | testuser@gmail.com |          | Password is required.      |
   | testuser@gmail.com | abcdef   | Authentication failed.     |

