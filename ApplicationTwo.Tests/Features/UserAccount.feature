Feature: UserAccount

Scenario: App2.User is sent to welcome page
	Given i am on the login page
	When i enter username 'JohnSmith'
	And i enter password 'Test'
	And i click login
	Then Welcome screen is shown

Scenario: App2.Correct user details are present
	Given i am on the login page
	When i enter username 'JohnSmith'
	And i enter password 'Test'
	And i click login
	Then the useraccount screen is shown
	And my username shows as 'JohnSmith'
	And firt name is 'John'
	And my last name is 'Smith'