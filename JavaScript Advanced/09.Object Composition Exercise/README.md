1.	Array extension
Extend the build-in Array object with additional functionality. Implement the following functionality:<br>
•	last() – returns the last element of the array<br>
•	skip(n) – returns a new array which includes all original elements, except the first n elements; n is a Number parameter<br>
•	take(n) – returns a new array containing the first n elements from the original array; n is a Number parameter<br>
•	sum() – returns a sum of all array elements<br>
•	average() – returns the average of all array elements

2.	Construction Crew
Write a JS program that receives a worker object as a parameter and modifies its properties. Workers have the following structure:<br>
{ weight: Number,<br>
  experience: Number,<br>
  bloodAlcoholLevel: Number,<br>
  handsShaking: Boolean }<br>
Weight is expressed in kilograms, experience in years and bloodAlcoholLevel is in milliliters. If you receive a worker who’s handsShaking property is set to true it means he needs to intake some alcohol in order to be able to work correctly. The required amount is 0.1ml per kilogram per year of experience. The required amount must be added to the existing amount. Once the alcohol is administered, change the handsShaking property to false.<br>
Workers whose hands aren’t shaking should not be modified in any way. Return them as they were.

3.	Car Factory
Write a JS program that assembles a car by given requirements out of existing components. The client will place an order in the form of an object describing the car. You need to determine which parts to use to fulfil the client’s order. You have the following parts in storage:<br>
An engine has power (given in horsepower) and volume (given in cubic centimeters). Both of these values are numbers. When selecting an engine, pick the smallest possible that still meets the requirements.<br>
Small engine: { power: 90, volume: 1800 }<br>
Normal engine: { power: 120, volume: 2400 }<br>
Monster engine: { power: 200, volume: 3500 }<br>
A carriage has a type and color. Both of these values are strings. You have two types of carriages in storage and can paint it any color.<br>
Hatchback: { type: 'hatchback', color: <as required> }<br>
Coupe: { type: 'coupe', color: <as required> }<br>
The wheels will be represented by an array of 4 numbers, each number represents the diameter of the wheel in inches. The size can only be an odd number. Round down any requirements you receive to the nearest odd number. 

4.	Extensible object
Create an object that can clone the functionality of another object into itself. Implement an extend(template) function that would copy all of the properties of template to the parent object and if the property is a function, add it to the object’s prototype instead.

5.	String extension
Extend the build-in String object with additional functionality. Implement the following functions:<br>
•	ensureStart(str) – append str to the beginning of a string, only if it’s not already present<br>
•	ensureEnd(str) – append str to the end of a string, only if it’s not already present<br>
•	isEmpty() – return true if the string is empty, false otherwise<br>
•	truncate(n) – truncates the string to n characters by removing words and appends an ellipsis (three periods) to the end. If a string is less than n characters long, return the same string. If it is longer, split the string where a space occurs and append an ellipsis to it so that the total length is less than or equal to n. If no space occurs anywhere in the string, return n – 3 characters and an ellipsis. If n is less than 4, return n amount of periods.<br>
•	format(string, …params) – static method to replace placeholders with parameters. A placeholder is a number surrounded by curly braces. If parameter index cannot be found for a certain placeholder, do not modify it. Note static methods are attached to the String object instead of it’s prototype. See the examples for more info.<br>
Note strings are immutable, so your functions will return new strings as a result.

6.	*Sorted List
Implement a collection, which keeps a list of numbers, sorted in ascending order. It must support the following functionality:<br>
•	add(elemenent) – adds a new element to the collection<br>
•	remove(index) – removes the element at position index<br>
•	get(index) – returns the value of the element at position index<br>
•	size – number of elements stored in the collection<br>
The correct order of the element must be kept at all times, regardless of which operation is called. Removing and retrieving elements shouldn’t work if the provided index points outside the length of the collection (either throw an error or do nothing). Note the size of the collection is not a function. Write your code such that the first function in your solution returns an instance of your Sorted List.

7.	DOM Traversal
Write a program that recursively traverses all child nodes of an HTML element and highlights a path to the deepest node. Your script will be placed inside an HTML page and a selector will be passed to it. Starting from a given node and searching downwards, once the node with the deepest nesting is found, add the class highlight to it to change its appearance. Add the same class to all parent nodes all the way to the selector. If two elements have the same depth, highlight the first encountered.
