I. Statements

1 -	Hello, JavaScript!
Write a JS function that can receive a name as input and print a greeting to the console.<br>
The input comes as a single string that is the name of the person.<br>
The output should be printed to the console.

2 -	Area and Perimeter
Write a JS function that calculates the area and perimeter of a rectangle by given two sides.<br>
The input comes as 2 numbers that are the lengths of the 2 sides of the rectangle (sideA and sideB)<br>
The output should be printed to the console on two lines.

3 -	Distance over Time
Two objects start from point A and travel in the same direction at constant speeds V1 and V2 for a period T. Write a JS function that calculates the distance between the two object at the end of the period.<br>
The input comes as array of numbers. The first two elements are the speeds to the two objects in km/h and the third element is the time in seconds.<br>
The output should be printed to the console. Calculate the distance in meters.

4 -	Distance in 3D
Write a JS function that calculates the distance between the two points in 3D by given coordinates.<br>
The input comes as an array of numbers. The first three elements are the x, y and z coordinates for the first point and the second set of arguments are the coordinates of the other point.<br>
The output should be printed to the console.

5 - Grads to Degrees
Land surveyors use grads (also known as gon, 400 grads in a full turn) in their documents. Grads are rather unwieldy though, so you need to write a JS function that converts from grads to degrees. In addition, your program needs to constrain the results within the range 0°≤x<360°, so if you arrive at a value like -15°, it needs to be converted to 345° and 420° becomes 60°.<br>
The input comes as single number.<br>
The output should be printed to the console.

6 -	Compound Interest
Write a JS function that calculates the total accumulated value for a monetary deposit by given principal sum, interest rate, compounding frequency and overall length.<br>
The input comes as an array of numbers. The first value is the principal sum, the second is the interest rate in percent, the third is the compounding period in months and the final value is the total timespan, given in years.<br>
The output should be printed to the console, with two decimal places.

7 -	*Rounding
Write a JS function that rounds numbers to specific precision.<br>
The input comes as an array of two numbers. The first value is the number to be rounded and the second is the precision (significant decimal places). If a precision is passed, that is more than 15 it should automatically be reduced to 15.<br>
The output should be printed to the console. Do not print insignificant decimals.

8 -	Imperial Units
Imperial units are confusing, but still in use in some backwards countries (Myanmar, Liberia and the United States are the only countries still using them). They are so confusing in fact, that native users struggle to convert between them. Write a JS function that converts from inches to feet and inches. There are 12 inches in a foot. See the example for formatting details.<br>
The input comes as a single number.<br>
The output should be printed to the console.

9 -	Now Playing
Write a JS function that displays information about the currently playing musical track.<br>
The input comes as an array of string elements. The first element is the name of the track, the second is the name of the artist performing and the third is the duration in minutes and seconds.<br>
The output should be printed to the console in the following format:<br>
Now Playing: {artist name} - {track name} [{duration}]

10 - Compose Tag
Write a JS function that composes an HTML image tag.<br>
The input comes as an array of string elements. The first element is the location of the file and the second is the alternate text.<br>
The output should be printed to the console in the following format:<br>
<img src="{file location}" alt="{alternate text}">

11 - Binary to Decimal
Write a JS function that reads an 8-bit binary number and converts it to a decimal.<br>
The input comes as one string element, representing a binary number.<br>
The output should be printed to the console.

12 - Assign Properties
Write a JS function that composes an object by given properties. There will be 3 sets of property-value pairs (a total of 6 elements). Assign each value to its respective property of an object and return the object as a result of the function.<br>
The input comes as an array of string elements.<br>
The output should be returned as a value.

13 - *Last Month
Write a JS function that receives a date as array of strings containing day, month and year in that order. Your task is to print the last day of previous month (the month BEFORE the given date). Check the examples to better understand the problem.<br>
The input comes as an array of numbers.<br>
The output should be a single number representing the last day of the previous month.

II. Conditional Statements and Loops

14 - Biggest of 3 Numbers
Write a JS function that finds the biggest of 3 numbers.<br>
The input comes as array of 3 numbers.<br>
The output is the biggest from the input numbers.

15 - Point in Rectangle
Write a JS function that takes as input 6 numbers x, y, xMin, xMax, yMin, yMax and prints whether the point {x, y} is inside the rectangle or outside of it. If the point is at the rectangle border, it is considered inside.<br>
The input comes as array of numbers. Its holds the representations of x, y, xMin, xMax, yMin, yMax. All numbers will in the range [-1 000 000 … 1 000 000]. It is guaranteed that xMin < xMax and yMin < yMax.<br>
The output is a single line holding “inside” or “outside”.

16 - Odd Numbers 1 to N
Write a JS function that reads an integer n and prints all odd numbers from 1 to n.<br>
The input comes as a single number n. The number n will be an integer in the range [1 … 100 000].<br>
The output should hold the expected odd numbers, each at a separate line.

17 - Triangle of Dollars
Write a JS function that prints a triangle of n lines of “$” characters like shown in the examples.<br>
The input comes as a single number n (0 < n < 100).<br>
The output consists of n text lines like shown below.

18 - Movie Prices
Write a JS function that calculate the ticket price by movie title and day of week.<br>
The input comes as array of 2 strings. The first string holds the movie title. The second string holds the day of week.<br>
The output should hold the ticket price or “error” if the title or day of week is invalid.

19 - Quadratic Equation
Write a JS function to solve a quadratic equation by given in standard form as its coefficients: a, b, c. You may learn more about quadratic equations here: https://www.mathsisfun.com/algebra/quadratic-equation.html.<br>
The input comes as 3 numbers a, b and c. The value of a will be non-zero.<br>
The output depends on the equation:<br>
•	It holds two numbers x1 and x2 if the equation has two different solutions (roots): x1 and x2.<br>
o	First print the smaller root, then the greater.<br>
•	It holds a single number x if the equation has only one solution (root): x.<br>
•	It holds the text “No” if the equation has no solutions (no real roots).

20 - Multiplication Table
Write a JS function to print a math multiplication table of size n, formatted as HTML table.<br>
The input comes as a single number n (0 < n < 100).<br>
The output consists of n+3 text lines like shown below.

21 - Figure of 4 Squares
Write a JS function to print a figure of 4 squares of size n like shown in the examples below.<br>
The input is an integer number n in the range [2 … 200].<br>
The output consists of n lines for odd n and n-1 lines for even n. Each line holds 2*n-1 characters (+ or | or space) as shown in the examples. The figure is fully symmetric (horizontally and vertically).
