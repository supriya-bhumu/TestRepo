Feature: TMFeature

create, edit and delete records


Scenario: TC1Create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I create a new time and material record
	Then The record should be created successfully

Scenario Outline: TC2Edit Time and material record with valid details
    Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And I update '<Description>', '<Code>' and '<Price>' on an existing time and material record
	Then The record should have the updated '<Description>', '<Code>' and '<Price>'

Examples: 
| Description  | Code     | Price |
| abc          | Galen    | 20    |
| 123          | Keyboard | 100   |
| EditedRecord | Mouse    | 1500  |

Scenario: TC3Delete time and material record 
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	Then I delete an existing time and material record successfully


