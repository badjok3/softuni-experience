I. Error Handling

1.	Request Validator
Write a JS function that validates an HTTP request object. The object has the properties method, uri, version and message. Your function must receive the object as a parameter and verify that each property meets the following requirements:<br>
•	method – can be GET, POST, DELETE or CONNECT<br>
•	uri – must be a valid resource address or an asterisk (*); a resource address is a combination of alphanumeric characters and periods; all letters are Latin; the URI cannot be an empty string<br>
•	version – can be HTTP/0.9, HTTP/1.0, HTTP/1.1 or HTTP/2.0 supplied as a string<br>
•	message – may contain any number of non-special characters; special characters are <, >, \, &, ', "<br>
If a request is valid, return it unchanged. If any part fails the check, throw an Error with message "Invalid request header: Invalid {Method/URI/Version/Message}". Replace the part in curly braces with the relevant word. Note that some of the properties may be missing, in which case the request is invalid. Check the properties in the order in which they are listed here. If more than one property is invalid, throw an error for the first encountered.

II. Unit Testing

2 -	Even or Odd
You need to write unit tests for a function isOddOrEven that checks whether a passed in string has even or odd length. The function has the following functionality:<br>
•	isOddOrEven(string) - A function that accepts a string and determines if the string has even or odd length.<br>
o	If the passed parameter is not a string return undefined.<br>
o	If the parameter is a string - return either "even" or "odd" based on the string's length.

3 -	Char Lookup
You are tasked with writing unit tests for a simplistic function that retrieves a character (a string containing only 1 symbol in JS) at a given index from a passed in string.<br>
You are supplied a function named lookupChar, which should have the following functionality:<br>
•	lookupChar(string, index) - A function that accepts a string - the string in which we’ll search and a number - the index of the char we want to lookup:<br>
o	If the first parameter is not a string or the second parameter is not an integer - return undefined.<br>
o	If both parameters are of the correct type, but the value of the index is incorrect (bigger than or equal to the string length or a negative number) - return the text "Incorrect index". <br>
o	If both parameters have correct types and values - return the character at the specified index in the string.

4.	Math Enforcer
Your task is to test a variable named mathEnforcer, which represents an object that should have the following functionality: <br>
•	addFive(num) - A function that accepts a single parameter:<br>
o	If the parameter is not a number, the funtion should return undefined.<br>
o	If the parameter is a number, add 5 to it, and return the result.<br>
•	subtractTen(num) - A function that accepts a single parameter:<br>
o	If the parameter is not a number, the function should return  undefined.<br>
o	If the parameter is a number, subtract 10 from it, and return the result.<br>
•	sum(num1, num2) - A function that should accepts two parameters:<br>
o	If any of the 2 parameters is not a number, the function should return undefined.<br>
o	If both parameters are numbers, the function should return their sum. 

5.	Shared Object
You are tasked to test a sharedObject responsible for keeping a valid state between a JS object and two HTML textboxes. The two textboxes will always have ids name for the name textbox and income for the income textbox, and will always start with empty strings as values. The sharedObject should have the following functionality:<br>
•	name - a property holding a string, starts with value null by default.<br>
•	income - a property holding a number, starts with value null by default.<br>
•	changeName(name) - In case the passed in parameter is an empty string - no changes should be made, alternatively the sharedObject's name property and the name textbox's value should be set to the passed in parameter.<br>
•	changeIncome(income) - In case the passed in parameter is not a positive integer  - no changes should be made, alternatively the sharedObject's income property and the income textbox's value should be set to the passed in parameter.<br>
•	updateName() - In case the name textbox's value is an empty string - no changes should be made, alternatively the name property of the sharedObject should be set to the value of the name textbox. <br>
•	updateIncome() - In case the income textbox's value cannot be parsed to a positive integer - no changes should be made, alternatively the income property of the sharedObject should be set to the value of the income textbox.

