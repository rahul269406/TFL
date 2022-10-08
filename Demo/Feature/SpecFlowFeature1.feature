Feature: TFL Assignment


@test1 @test4
Scenario Outline: Verify that a valid journey can be planned  and edited.
	Given User is on the tfl home page
	When click on plan a journey tab
	When user enter from  "<From Location>" location
	When user enter to  "<To Location>" location
	When click on plan a journey Button
	Then Verify results
	Then Verify Edit link to edit the journey planned
	Then close the driver

	Examples:
	| From Location           | To Location   |
	| Brighton                | London Bridge |
	

	@test2
Scenario Outline:Verify that the widget is unable to provide results when an invalid journey is
planned.
	Given User is on the tfl home page
	When click on plan a journey tab
	When user enter from  "<From Location>" location
	When user enter to  "<To Location>" location
	When click on plan a journey Button
	Then Verify results
	Then close the driver

	Examples:
	| From Location           | To Location   |
	| 555555555                | 43434342334234 |


		@test3
Scenario Outline: Verify that the widget is unable to plan a journey if no locations are entered into the
widget.
	Given User is on the tfl home page
	When click on plan a journey tab
	When user enter from  "<From Location>" location
	When user enter to  "<To Location>" location
	When click on plan a journey Button
	Then Verify results
	Then close the driver

	Examples:
	| From Location           | To Location   |
	|               |     |

@test5
Scenario Outline: Verify that the “Recents” tab on the widget displays a list of recently planned
journeys.
	Given User is on the tfl home page
	When click on plan a journey tab
	When user enter from  "<From Location>" location
	When user enter to  "<To Location>" location
	When click on plan a journey Button
	Then Verify results
	When click on plan a journey tab
	Then Navigate to recent tab and Verify Recent Journeys
	Then close the driver

	Examples:
	| From Location           | To Location   |
	| Brighton                | London Bridge |

	
