Feature: Shopping Functionality 

This feature provides user shopping

Background: User is on the shopping page
	Given User navigates to login page
	When User enters credentials 'standard_user' and 'secret_sauce'
	And User clicks the login button
	Then User sees the products
	When User clicks the add to cart button for backpack
	And User goes to cart page

Scenario Outline: User can shopping with valid required data
	Given User clicks on checkout button
	When Enter required data with "<FirstName>", "<LastName>" and "<Zipcode>"
	And User clicks on continue button
	And Verify total payment amount is correct
	And User clicks on finish button
	Then Confirm order is dispatched

	Examples: 
		| FirstName | LastName   | Zipcode   |
		| Onur      | Sevgili    | 06320     |



Scenario: User can not shopping with invalid data
Given User clicks on checkout button
	When User enter firstname 
	And User clicks on continue button
	Then User should be able to see error message to complete required data
