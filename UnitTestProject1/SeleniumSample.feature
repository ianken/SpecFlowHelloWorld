Feature: SeleniumSample
	Selenium web driver hello world

@mytag
Scenario: Simple Selenium Sample
	Given Chrome is running
	And I have navigated to https://www.bing.com/
	Then verify website destiantion https://www.bing.com/
