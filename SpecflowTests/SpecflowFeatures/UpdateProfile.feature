Feature: User updates the Profile
		 In order to update my profile
		 As a skill trader
		 I want to add my skills and relevant details

Background: 
Given Use r is using Chrome browser 
When  User navifgates to "http://www.skillswap.pro/" url
And   User enters valid login credentials "diliniwijenayaka@gmail.com" and "1qaz2wsx@"
Then  User is able to Log in to the application


Scenario Outline: 1 Check whether the user is able to add Languages to the profile
		Given User clicks on the 'Languages' tab in Profile page
		And   User clicks on the 'Add New' button
		When  User adds a new Language <Language> and <Language Level>
		Then  that <Language> language should be added to the 'Languages' page

Examples: 
             | Language | Language Level |
             | Spanish  | Basic          |



Scenario Outline: 2 Check whether the user is able to add Skills to the profile
        Given User clicks on the 'Skills' tab in Profile page
		And   User clicks on the 'Add New' button
		When  User adds a new skill <Skill> and <Skill Level>
		Then  that <Skill> skill should be added to the 'Skills' page

Examples: 
		     | Skill | Skill Level  |
		     | Java  | Intermediate |



Scenario Outline: 3 Check whether the user is able to add Education details to the profile
         Given User clicks on the 'Education' tab in Profile Page
		 And   User clicks on the 'Add New' button
		 When  User adds a new Education <Conutry>,<University>,<Title>,<Degree> and <Graduation Year>
		 Then  that <Education> education details should be added to the 'Education' page

Examples: 
			 | Country     | University        | Title | Degree | Graduation Year |
			 | New Zealand | Massey University | B.Sc  | Honors | 2017            |



Scenario Outline: 4 Check whether the user is able to add Certifications to the profile
         Given User clicks on the 'Certifications' tab in Profile page
		 And   User clicks on the 'Add New' button
		 When  User adds a new Certification <Certificate>, <From> and <Year>
		 Then  that <Certification> certification shoul dbe added to the 'Certification' page

Examples: 
			 | Certificate | From  | Year |
			 | ISTQB       | ANZTB | 2016 |



Scenario Outline: 5 Check whether the user is able to Edit the added Language successfully
		  Given User clicks on the 'Lnaguage' tab in Profile page
		  And   User clicks on the 'Edit' button
		  When  User update the Language information <Language Level>
		  Then  that updated details should be visible on the 'Languages'page

Examples: 
              | Language | Language Level |
              | Spanish  | Fluent         |


Scenario Outline: 6 Check whether the user is able to Delete the added Language successfully
          Given User clicks on the 'Language' tab in Profile Page
		  When  User clicks on the 'Delete' button
		  Then  that Language should not be visible on the Language page

Examples: 
              | Language | Language Level |
              | Spanish  | Fluent         |