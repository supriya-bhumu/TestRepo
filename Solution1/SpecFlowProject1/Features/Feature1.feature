Feature: ProfileFeature
I would like to add  Data to Profile page successfully
Background: 
Given I logged into QAMars Project successfully
   
Scenario:Add and save name with valid credentials
	
	When I entered and saved name
	Then the profile page should show the added name successfully.
Scenario:Add and save description to profile page
	
	When I entered and saved description
	Then the profile page should show the added description.
Scenario:Add availability to profile page
	
	When I selected the availability option
	Then the profile page should show the selected availability option.
Scenario:Add hours to profile page
	
	When I selected the suitable option for hours
	Then the profile page should show the selected hours option.
Scenario:Add earn target to profile page
	
	When I selected the suitable option for earn target
	Then the profile page should show the selected earn target option.

Scenario: Add skills and corresponding level to profile page
	
	When I added Skills and slect option for level in profile page
	Then the profile page should show the added Skills and level selected on profile page.
Scenario: Add college/university name, degree and corresponding country, title and year of graduation to profile page
	
	When  I added college/university name, degree and slect option for country, title and year of graduation in profile page
	Then the profile page should show the added college/university name, degree  along with selected options for country, title and year of graduation on profile page.

Scenario Outline: Add language and corresponding level to profile page
	
	When I added '<Language>' and slect option for '<Level>' in profile page
	Then the profile page should show the added '<Language>' and '<Level>' selected on profile page.

	Examples: 
| Language | Level          |
| English  | Conversational |
| Telugu   | Fluent         |
| Hindi    | Conversational | 

Scenario Outline: Add Certificate, issued institute and corresponding year of certification to profile page
	
	When  I added '< Certificate >', issued '<Institute>' and slect option for '<Year>' of certification in profile page
	Then the profile page should show the added '<Certificate>', issued '<Institute>' along with selected  '<Year>' of certificationon profile page.

	Examples: 
| Certificate   | Institute  | Year |
| Java Basic    | HackerRank | 2021 |
| SQL Basic     | HackerRank | 2021 |
