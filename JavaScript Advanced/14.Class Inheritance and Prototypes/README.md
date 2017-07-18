1.	Person and Teacher
Write a JS class Person and a class Teacher which extends Person. A Person should have a name and an email. A Teacher should have a name, an email, and a subject.

2.	Inheriting and Replacing ToString
Extend the Person and Teacher from the previous task and add a class Student inheriting from Person. Add toString() functions to all classes, the formats should be as follows:<br>
•	Person - returns "Person (name: {name}, email: {email})"<br>
•	Student - returns "Student (name: {name}, email: {email}, course: {course})"<br>
•	Teacher - returns "Teacher (name: {name}, email:{email}, subject:{subject})"<br>
Try to reuse code by using the toString function of the base class.

3.	Extend Prototype
Write a JS function which receives a class and attaches to it a property species and a function toSpeciesString().

4.	Class Hierarchy
Write a JS function that returns 3 classes - Figure, Circle, Rectangle. <br>
Figure:<br>
•	should be abstract (cannot be instantiated)<br>
Circle:<br>
•	extends Figure.<br>
•	has a property radius<br>
•	overrides area getter to return the area of the Circle (PI * r * r)<br>
•	toString() - should return a string representation of the figure in the format "{type} - radius: {radius}"<br>
Rectangle<br>
•	extends Figure<br>
•	has properties width and height<br>
•	overrides area getter to return the area of the Rectangle (width * height)<br>
•	toString() - should return a string representation of the figure in the format "{type} - width: {width}, height: {height}"

