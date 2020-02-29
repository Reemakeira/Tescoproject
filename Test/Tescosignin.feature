Feature: Tescosignin
In order to view welcome page
as a user
I can see the page

@Tesco
Scenario: Navigate to Tesco welcome page
Given Navigate to Tesco
When I enter correct email address and password
Then I can see welcome page
