Feature: ReqRes API Tests
	

@mytag
Scenario Outline: Successful registration
	When I register a new user with credentials <username> and <password>
	Then The registeration should be successfull
	And Token shoud be returned

Examples: 
| username		   | password |
|eve.holt@reqres.in|pistol|

Scenario Outline: Unsuccessful registration
	When I register a new user with credentials <username> and <password>
	Then The registeration should not be successfull

Examples: 
| username | password |
| shivam.kukreja@nagarro.com |	BlackPearl |

Scenario: List Users
When user send a GET request
Then should be getting a list of users


