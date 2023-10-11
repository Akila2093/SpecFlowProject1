Feature: SIGNUP
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Signup
Scenario: Sign up for W3 schools
Given open browser
	Given Go to w3 schoold link
	When click on sign up
	Then clikc on sign up for free
	Then enter email id
	Then enter password
	Then Clikc on sogn up for free
	Then Enter First Name
	Then Enter Last Name
	Then Click Continue
	Then Close Browser
	
	 