Feature: TableExample
	Simple table example

@mytag
Scenario: Add numbers from table
	Given user enters the following values
	| FirstNumber | SecondNumber |
	| 15		  | 10		     |
	| 23		  | 10           |
	Then validate results
	| result |
	| 25  |
	| 33  |
