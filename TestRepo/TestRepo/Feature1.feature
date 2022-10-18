Feature: TMFeature

create, edit and delete records

@tag1
Scenario: create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I create a new time and material record
	Then The record should be created successfully
