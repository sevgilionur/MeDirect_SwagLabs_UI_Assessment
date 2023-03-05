Feature: Login Functionality

This feature provides to be able to login and check the result

Scenario Outline: User should be able to login with valid credentials
	Given User navigates to login page
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the products
	Examples:
	| userName                | Password     |
	| standard_user           | secret_sauce |
	| performance_glitch_user | secret_sauce |


Scenario Outline: User cannot login with locked user credentials
	Given User navigates to login page
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the locked out user message
	Examples:
	| userName                | Password     |
	| locked_out_user         | secret_sauce |

	Scenario Outline: User login with problem user credentials
	Given User navigates to login page
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the problem user images
	Examples:
	| userName             | Password     |
	| problem_user         | secret_sauce |

	Scenario Outline: User cannot login with invalid credentials
	Given User navigates to login page
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the error message
	Examples:
	| userName         | Password    |
	| onur             | onur        |
	| test             | test        |
	| test             |             |
	|                  | test        |