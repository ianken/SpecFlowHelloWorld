Feature: TableExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add numbers from table
	Given user enters the follwing values
	| FirstNumber | SecondNumber |
	| 15		  | 10		     |
	| 23		  | 10           |
	Then results should be validted
	| result |
	| 25  |
	| 33  |

