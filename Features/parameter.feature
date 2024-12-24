@sprint1
Feature: Login with Parameter

@regression
Scenario: Verify login functionality with valid credentials
	Given User is on the login to page
	When User enters valid "<username>" and "<password>"
	And User click on the login button
	Then User navigated to home page
Examples:
	| username | password |
	| Admin    | admin123 |

@sanity
Scenario Outline: Verify login with test parameters
	Given User is on the login to page
	When User enter the "<username>" and "<password>"
	And User click on the login button
	Then User navigated to home page
	Then User selects city and country information
	| city | country |
		| Delhi | India   |
		| London | UK      |

Examples: 
	| username | password |
	| Admin    | admin123 |