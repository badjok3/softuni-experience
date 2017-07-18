I. Classes

1.	Data Class
Write a JS class that holds data about an HTTP request. It has the following properties:<br>
•	method (String)<br>
•	uri (String)<br>
•	version (String)<br>
•	message (String)<br>
•	response (String)<br>
•	fulfilled (Boolean)<br>
The first four properties (method, uri, version, message) are set trough the constructor, in the listed order. The response property is initialized to undefined and the fulfilled property is initially set to false.

2.	Tickets
Write a JS program that manages a database of tickets. A ticket has a destination, a price and a status. Your program will receive two argument – the first is an array of strings for ticket descriptions and the second is a string, representing a sorting criteria. The ticket descriptions have the following format:<br>
<destinationName>|<price>|<status><br>
Store each ticket and at the end of execution return a sorted summary of all tickets, sorted by either destination, price or status, depending on the second parameter that your program received. Always sort in ascending order (default behavior for alphabetical sort). If two tickets compare the same, use order of appearance. See the examples for more information.

3.	Unity
Rats are uniting.<br>
Create a class, Rat, which holds the functionality to unite with other objects of the same type. Make it so that the object holds all of the other objects it has connected to.<br>
The class should have a name, which is a string, and it should be initialized with it. <br>
The class should also hold a function unite(otherRat), which unites the first object with the given one. An object should store all of the objects it has united to. The function should only add the object if it is an object of the class Rat. In any other case it should do nothing.<br>
The class should also hold a function getRats() which returns all the rats it has united to, in a list.<br>
Implement functionality for toString() function… which returns a string representation of the object and all of the objects its united with, each on a new line. On the first line put the object’s name and on the next several lines put the united objects’ names, each with a padding of “##”. 

4.	Length Limit
Create a class, Stringer, which holds single string and a length property. The class should be initialized with a string, and an initial length. The class should always keep the initial state of its given string.<br>
Name the two properties innerString and innerLength.<br>
There should also be functionality for increasing and decreasing the initial length property.<br>
Implement function increase(length) and decrease(length), which manipulate the length property with the given value.<br>
The length property is a numeric value and should not fall below 0. It should not throw any errors, but if an attempt to decrease it below 0 is done, it should be automatically set to 0.<br>
You should also implement functionality for toString() function, which returns the string, the object was initialized with. If the length of the string is greater than the length property, the string should be cut to from right to left, so that it has the same length as the length property, and you should add 3 dots after it, if such truncation was done.<br>
If the length property is 0, just return 3 dots.

5.	Extensible Class
Revisit the problem Extensible Object from Object Composition. Refactor the code so that instead of a single instance, you deliver a class that can be extended. The class has an extend(template) method that would copy all of the properties of template to the instance (not to all instances, just the one from which the method was called) and if the property is a function, add it to the object’s prototype instead.<br>
In addition, the base class needs to have an ID property that is unique and autoincremented sequentally for every new instance.

6.	Sorted List
Revisit the problem Sorted List from Object Composition. Refactor the code so instead of an instance, you deliver a class. Implement a collection, which keeps a list of numbers, sorted in ascending order. It must support the following functionality:<br>
•	add(elemenent) – adds a new element to the collection<br>
•	remove(index) – removes the element at position index<br>
•	get(index) – returns the value of the element at position index<br>
•	size – number of elements stored in the collection<br>
The correct order of the elements must be kept at all times, regardless of which operation is called. Removing and retrieving elements shouldn’t work if the provided index points outside the length of the collection (either throw an error or do nothing). Note the size of the collection is not a function.

7.	Instance Validation
Write a class for a checking account that validates it’s created with valid parameters. A CheckingAccount has a clientId, email, firstName, lastName all set trough the constructor and an array of products that is initially empty. Each parameter must meet specific requirements:<br>
•	clientId – must be a string representing a 6-digit number; if invalid, throw a TypeError with the message "Client ID must be a 6-digit number"<br>
•	email – must contain at least one alphanumeric character, followed by the @ symbol, followed by one or more letters or periods; all letters must be Latin; if invalid, throw a TypeError with message "Invalid e-mail"<br>
•	firstName, lastName – must be at least 3 and at most 20 characters long, containing only Latin letters; if the length is invalid, throw a TypeError with message "{First/Last} name must be between 3 and 20 characters long"; if invalid characters are used, throw a TypeError with message "{First/Last} name must contain only Latin characters" (replace First/Last with the relevant word);<br>
All checks must happen in the order in which they are listed – if more than one parameter is invalid, throw an error for the first encountered. Note that error messages must be exact.<br>
Submit your solution containing a single class definition.

II. Classes Interacting with DOM Elements

8.	View Model
Do you remember the sharedObject problem from unit testing, we're going to build upon the idea and create an object that ensures a set of DOM elements and a JS object share the same state.<br>
We need to create a class Textbox that represents one or more HTML input elements with type="text". The constructor takes as parameters a selector and a regex for invalid symbols. <br>
Textbox elements created from the class should have:<br>
•	public property value (has getters and setters) <br>
•	private property _elements containing the set of elements matching the selector<br>
•	public getter elements for the private _elements property<br>
•	private property _invalidSymbols - a regex used for validating the textbox value<br>
•	method isValid() - if the _invalidSymbols regex can be matched in the current textbox value return false, otherwise return true.<br>
All _elements values and the value property should be linked. If the value of an element from _elements changes all other elements' values and the value property should instantly reflect it, likewise should happen if the value property changes. 
