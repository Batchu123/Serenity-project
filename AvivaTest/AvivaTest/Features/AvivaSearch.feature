Feature: AvivaSearch
	Check if links related to aviva are displayed or not

@mytag
Scenario: Search for aviva on google Home page
	Given I have lauchned the google home page
	And I have entered the search text "Aviva"
	When I press search button
	Then I should be able to see the links related to the search text
