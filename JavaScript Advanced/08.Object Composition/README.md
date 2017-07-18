1.	Order Rectangles
You will be passed a few pairs of widths and heights of rectangles, create objects to represent the rectangles. The objects should additionally have two functions area - that returns the area of the rectangle and compareTo - that compares the current rectangle with another and produces a number  signifying if the current rectangle is smaller (negative number), equal (0) or larger(positive number) than the other rectangle. 

2.	Fibonacci
Write a JS function that when called, returns the next Fibonacci number, starting at 0, 1. Use a closure to keep the current number.

3.	List Processor
Using a closure, create an inner object to process list commands. The commands supported should be the following:<br>
•	add <string> - adds the following string in an inner collection.<br>
•	remove <string> - removes all occurrences of the supplied <string> from the inner collection.<br>
•	print - prints all elements of the inner collection joined by ", ".

4.	Cars
Write a closure that can create and modify objects. All created objects should be kept and be accessible by name. You should support the following functionality:<br>
•	create <name> - creates an object with the supplied <name><br>
•	create <name> inherits <parentName> - creates an object with the given <name>, that inherits from the parent object with the <parentName><br>
•	set <name> <key> <value> - sets the property with key equal to <key> to <value> in the object with the supplied <name>.<br>
•	print <name> - prints the object with the supplied <name> in the format "<key1>:<value1>,<key2>:<value2>…" - the printing should also print all inherited properties from parent objects. Inherited properties should come after own properties.

5.	Sum
Create a function which returns an object that can modify the DOM. The returned object should support the following functionality:<br>
•	init(selector1, selector2, resultSelector) - initializes the object to work with the elements corresponding to the supplied selectors.<br>
•	add() - adds the numerical value of the element corresponding to selector1 to the numerical value of the element corresponding to selector2 and then writes the result in the element corresponding to resultSelector<br>
•	subtract() - subtracts the numerical value of the element corresponding to selector2 from the numerical value of the element corresponding to selector1 and then writes the result in the element corresponding to resultSelector

