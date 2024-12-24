@sprint2
Feature: Login to OrganeHRM Application

Background: 
	Given User is on the login page

@sanity
Scenario: Verify login functionality with valid credentials
	When User enters valid username and password
	And User clicks on the login button
	Then User is navigated to home page