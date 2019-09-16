Feature: FLight Booking

@mytag
Scenario Outline: Multi City Flight
	Given I am on the expedia home page
	When I click on flight button and select's multi city option
	Then I go for three different flight leg's between airports <FIRST>,<SECOND>,<THIRD> on dates <Date1>,<Date2>,<Date3>  for <number> adults
	And I choose the first available option
	And I make sure that the trip total is equal to price per person multiplied by the number of people <number>

Examples:
| FIRST | SECOND | THIRD | Date1      | Date2      | Date3      | number |
| MLA   | LON    | ROM   | 09/20/2019 | 09/23/2019 | 09/26/2019 | 4      |