1.	Inside Volume
Write a JS function that determines whether a point is inside the volume, defined by the box, shown on the right.<br>
The input comes as an array of numbers. Each set of 3 elements are the x, y and z coordinates of a point.<br>
The output should be printed to the console on a new line for each point. Print inside if the point lies inside the volume and outisde otherwise.<br>

2.	Road Radar
Write a JS function that determines whether a driver is within the speed limit. You will receive his speed and the area where he’s driving. Each area has a different limit: on the motorway the limit is 130 km/h, on the interstate the limit is 90, inside a city the limit is 50 and within a residential area the limit is 20 km/h. If the driver is within the limits, your function prints nothing. If he’s over the limit however, your function prints the severity of the infraction. For speeds up to 20 km/h over the limit, he’s speeding; for speeds up to 40 over the limit, the infraction is excessive speeding and for anything else, reckless driving.<br>
The input comes as an array of elements. The first element is the current speed (as number), the second element is the area where the vehicle is driving.<br>
The output should be printed to the console. Note in certain cases there will be no output.

3.	Template format
Write a JS program that receives data about a quiz and prints it formatted as an XML document. The data comes as pairs of question-answer entries. The format of the document should be as follows:<br>
XML<br>
<?xml version="1.0" encoding="UTF-8"?><br>
<quiz><br>
  <question><br>
    {question text}<br>
  </question><br>
  <answer><br>
    {answer text}<br>
  </answer><br>
</quiz><br>
The input comes as an array of string elements.<br>
The output should be printed on the console.

4.	Cooking by Numbers
Write a JS program that receives a number and a list of five operations. Perform the operations in sequence by starting with the input number and using the result of every operation as starting point for the next. Print the result of every operation in order. The operations can be one of the following:<br>
•	chop – divide the number by two<br>
•	dice – square root of number<br>
•	spice – add 1 to number<br>
•	bake – multiply number by 3<br>
•	fillet – subtract 20% from number<br>
The input comes as an array of 6 string elements. The first element is your starting point and must be parsed to a number. The remaining 5 elements are the names of operations to be performed.<br>
The output should be printed on the console.

5.	Modify Average
Write a JS program that modifies a number until the average value of all of its digits is higher than 5. In order to modify the number, your program should append a 9 to the end of the number, when the average value of all of its digits is higher than 5 the program should stop appending. If the number’s average value of all of its digits is already higher than 5, no appending should be done.<br>
The input is a single number.<br>
The output should consist of a single number - the final modified number which has an average value of all of its digits higher than 5. The output should be printed on the console.

6.	Validity Checker
Write a JS program that receives two points in the format [x1, y1, x2, y2] and checks if the distances between each point and the start of the cartesian coordinate system (0, 0) and between the points themselves is valid. A distance between two points is considered valid, if it is an integer value. In case a distance is valid write "{x1, y1} to {x2, y2} is valid", in case the distance is invalid write "{x1, y1} to {x2, y2} is invalid". <br>
The order of comparisons should always be first {x1, y1} to {0, 0}, then {x2, y2} to {0, 0} and finally {x1, y1} to {x2, y2}. <br>
The input consists of two points given as an array of numbers.<br>
For each comparison print on the output either "{x1, y1} to {x2, y2} is valid" if the distance between them is valid, or "{x1, y1} to {x2, y2} is invalid"- if it’s invalid.

7.	Treasure Locator
You will be given a series of coordinates, leading to a buried treasure. Use the map to the right to write a program that locates on which island it is. After you find where all the treasure chests are, compose a list and print it on the console. If a chest is not on any of the islands, print “On the bottom of the ocean” to inform your treasure-hunting team to bring diving gear. If the location is on the shore (border) of the island, it’s still considered to lie inside.<br>
The input comes as an array with a variable number of elements that are numbers. Each pair is the coordinates to a buried treasure chest.<br>
The output is a list of the locations of every treasure chest, either the name of an island or “On the bottom of the ocean”, printed on the console.

8.	Trip Length
You will be given the coordinates of 3 points on a 2D plane. Write a program that finds the two shortest segments that connect them (without going back to the starting point). When determining the listing order, use the order with the lowest numerical value (see the figure in the hints for more information).<br>
The input comes as an array of 6 numbers. The order is [x1, y1, x2, y2, x3, y3].<br>
The output is the return value of your program as a string, representing the order in which the three points must be visited and the final distance between them. See the examples for more info.