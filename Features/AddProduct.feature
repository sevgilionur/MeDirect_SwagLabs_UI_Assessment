Feature: Add to cart feature functionality

This feature provides to check the Add To Cart functionality

Background: User is on the product page
	Given User navigates to login page
	When User enters credentials 'standard_user' and 'secret_sauce'
	And User clicks the login button

Scenario: User should be able to add products to cart
	Then User sees the products
	When User clicks the add to cart button for backpack
	And User clicks the add to cart button for tshirt
	And User goes to cart page
	Then User should be able to see added products 




