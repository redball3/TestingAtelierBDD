Feature: Login

Scenario: Login with correct credentials
	Given i am on the login page
	When i enter username 'JohnSmith'
	And i enter password 'Test'
	And i click login
	Then the useraccount screen is shown

Scenario: Login with incorrect credentials
	Given i am on the login page
	When i enter username 'JohnSmith'
	And i enter password 'Invalid'
	And i click login
	Then the useraccount screen is not shown

Scenario: Login with no credentials
	Given i am on the login page
	When i enter username ''
	And i enter password ''
	And i click login
	Then the useraccount screen is not shown