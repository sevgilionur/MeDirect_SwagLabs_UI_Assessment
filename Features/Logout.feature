Feature: Logout Functionality on Product Page

This feature provides user log out without buying product

Background: User in on the product page
	Given User navigates to login page
	When User enters credentials for standart_user
	And User clicks the login button
	Then User sees the products

	Scenario: User log out without buying product
	When User clicks on open menu button
	And User clicks the log out button
	Then User sees the login page


