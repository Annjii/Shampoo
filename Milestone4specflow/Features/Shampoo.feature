Feature: Shampoo

Scenario: search shampoo
	Given Navigate to Url 
	Then Click on Search box
	When Type Shampoo in Search box and hit enter
	And Verify the Search results
	And Check if First Search result Matches to given capture


Scenario: StopTheBeautyTest
	Given load website 
	When Scroll to navigate Let's StopTheBeautyTest Section
	Then Click on discover more under Let's StopTheBeautyTest Section
	And check and verify if loaded page shows the real women behind stopthebeauty test option

Scenario:footer
	Given load Url in browser
	When Scroll to footer
	Then click on terms of use
	And check and verify if a section with prohibited uses avaiable or not 