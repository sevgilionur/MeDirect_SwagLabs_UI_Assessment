Feature: Remove product feature functionality

Remove product feature after adding products to cart

Background: User is on the cart page
Given User navigates to login page
	When User enters credentials 'standard_user' and 'secret_sauce'
	And User clicks the login button
	Then User sees the products
	When User clicks the add to cart button for backpack
	And User goes to cart page

Scenario: User should be able to remove products from cart in the cart page
	When User clicks on remove button for removing backpack
	Then User sees shopping cart empty
