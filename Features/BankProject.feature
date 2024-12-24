Feature: BankProject

A short summary of the feature
Background:
    Given User is on the bank web page
    When User clicks on the bank manager login button

Scenario: Add new customer using bank manager login
    Given User finds the Add Customer tab
    When User clicks on the Add Customer tab
    And User enters the "<firstname>" "<lastname>" "<Pincode>" details
    And User clicks on Add Customer
    Then User gets the confirmation popup
Examples: 
	| firstname | lastname | Pincode |
	| Prasad    | Poojary  | 560037  |

Scenario: Open new account for recently added customer
    Given User finds the Open Account tab
    When User clicks on the Open Account tab
    And User selects the recently added customer from the dropdown list
    And User selects the currency type
    And User clicks on the Process button
    Then User gets the confirmation popup

Scenario: Verify the account details
    Given User finds the Customers button
    When User clicks on the Customers tab
    And User enters the recently added customer in the search box
    Then User gets the "<account>" details
    And User deletes the "<account>"
Examples: 
	| account        |
	| Prasad Poojary | 