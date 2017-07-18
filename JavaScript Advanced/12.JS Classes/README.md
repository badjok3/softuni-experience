1.	Rectangle
Write a JS class for a rectangle object. It needs to have a width (Number), height (Number) and color (String) properties, which are set from the constructor and a calcArea() method, that calculates and returns the rectangle’s area.

2.	Person
Write a JS class that represents a personal record. It has the following properties, all set from the constructor:<br>
•	firstName<br>
•	lastName<br>
•	age<br>
•	email<br>
And a method toString(), which prints a summary of the information. See the example for formatting details.<br>

3.	Get Persons
Write a JS function that returns an array of Person objects. Use the class from the previous task, create the following instances, and return them in an array.<br>
For any empty cells, do not supply a parameter (call the constructor with less parameters).

4.	Circle
Write a JS class that represents a Circle. It has only one data property – it’s radius, and it is set trough the constructor. The class needs to have getter and setter methods for its diameter – the setter needs to calculate the radius and change it and the getter needs to use the radius to calculate the diameter and return it.<br>
The circle also has a getter area(), which calculates and returns its area.

5.	Point Distance
Write a JS class that represents a Point. It has x and y coordinates as properties, that are set through the constructor, and a static method for finding the distance between two points, called distance().

6.	Cards
You need to write an IIFE that results in an object containing two properties Card which is a class and Suits which is an object that will hold the possible suits for the cards.<br>
The Suits object should have exactly these 4 properties:<br>
•	SPADES: ♠<br>
•	HEARTS: ♥<br>
•	DIAMONDS: ♦<br>
•	CLUBS: ♣<br>
Where the key is SPADES, HEARTS e.t.c. and the value is the actual symbol ♠, ♥ and so on.<br>
The Card class should allow for creating cards, each card has 2 properties face and suit. The valid faces are the following ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"] any other are considered invalid.<br>
The Card class should have setters and getters for the face and suit properties, when creating a card or setting a property validations should be performed, if an invalid face or a suit not in the Suits object is passed an Error should be thrown.
