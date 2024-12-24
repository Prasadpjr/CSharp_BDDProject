@sprint2
Feature: Registerform
@regression
Scenario: Fill details in the registration form
	Given user is on the registration page
	When user enters the "<Name>" "<EmailAddress>" "<Password>" "<Gender>" "<dateofbirth>" details
	Then fomrs filled successfully
Examples: 
		| Name | EmailAddress  | Password | Gender | dateofbirth |
		| John | abc@email.com | 12345    | Male   | 1990-01-02  |
		| Anil | xyz@email     | 33445    | Female | 1991-03-04  |
