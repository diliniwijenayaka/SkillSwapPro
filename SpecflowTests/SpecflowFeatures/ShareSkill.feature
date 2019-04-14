Feature: User shares skill details
		 In order to share skill details
		 As a skill trader
		 I want to add details of my skills 

Background:  
Given User is using Chrome browser 
When  User navifgates to "http://www.skillswap.pro/" url
And   User enters valid login credentials "diliniwijenayaka@gmail.com" and "1qaz2wsx@"
Then  User is able to Log in to the application


Scenario Outline: 7 Check whethr the user is able to share a relevant skill
         Given User clicks on the 'Share Skill' button
		 When  User enters the details <Title>,<Description>,<Category>,<Tags>,<Service Type>,<Location Type>, <Skill Trade>, <Skill Exchange>, <Credit> , <Work Samples> and <Active>
		 And   User enteres Available Days
		 Then  that Skill should be added to the Manage Listing page

		 Examples: 
		         | Title       | Description  | Category | Tags                | Service Type         | Location Type | Skill Trade | Skill Exchange | Credit | Work Samples    | Active |
		         | Skill Share | Professional | Business | Business Statistics | Hourly basis service | Online        | Credit      | Available      | 100    | WorkSamples.pdf | Active |


Scenario Outline: 8 Check whether the user is able to Edit the shared skill details
         Given User clicks on the Edit button on the Manage Listings page
		 When  User enters the details <Title>,<Description> and <Category>
		 And   User updates Available Days
		 Then  that updated details should be displayed on the Manage Listings page

         Examples: 
		          | Title            | Description | Category        | Service Type |
		          | Skill Share Test | Beginners   | Music and Audio | Hourly       |

     
Scenario Outline: 9 Check whether the user is able to Delete the shared skill
         Given User clicks on the Manage Listings tab
		 When  User clicks on the 'Delete' button
		 Then  that Shared Skill should no be visible on the Manage Listings page

Examples: 
		          | Title            | Description | Category        | Service Type |
		          | Skill Share Test | Beginners   | Music and Audio | Hourly       |