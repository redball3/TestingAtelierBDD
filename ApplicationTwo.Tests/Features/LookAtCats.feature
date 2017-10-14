Feature: LookAtCats

@mytag
Scenario: App2.UserCanLookAtCats
	Given i am on the login page
	When i enter username 'JaneBloggs'
	And i enter password 'Testing'
	And i click login
	And i navigate to the 'Look at Cats' tab
	Then i can look at some cats
