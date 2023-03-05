Feature: Filter Functionality on Product Page

This feature provides user filtering products

Background: User is on the product page
	Given User navigates to login page
	When User enters credentials for standart_user
	And User clicks the login button
	Then User sees the products


Scenario:  Filter functioanility verification
	When Select NameAToZ
	And Verify that products sorted from A to Z
	And Select NameZToZ
	And Verify that products sorted from Z to A
	And Select LowToHigh
	And Verify that products sorted from low to high
	And Select HighToLow
	Then Verify that products sorted from high to low
