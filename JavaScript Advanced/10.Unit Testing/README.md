I.Error Handling

1 -	Sub Sum
Write a JS function to sum a range of numeric elements from array. The function takes three parameters – the first is an array, the second is start index and the third is an end index. Both indexes are inclusive. Assume array elements may not be of type Number and cast everything. Implement the following error handling:<br>
•	if the first element is not an array, return NaN<br>
•	if the start index is less than zero, assume it is zero<br>
•	if the end index is outside the bounds of the array, assume it points to the last index of the array

2 -	Playing Cards
Create a JS factory function that returns a Card object to hold a card’s face and suit, both set trough the constructor. Throw an error if the card is initialized with invalid face or suit or if an attempt is made to change the face or suit of an existing instance to an invalid value.<br>
•	Valid card faces are: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A<br>
•	Valid card suits are: S (♠), H (♥), D (♦), C (♣)<br>
Both face and suit are expected as an uppercase string. The class also needs to have a toString() method that prints the card’s face and suit as a string. Use the following UTF code literals to represent the suits:<br>
•	\u2660 – Spades (♠)<br>
•	\u2665 – Hearts (♥)<br>
•	\u2666 – Diamonds (♦)<br>
•	\u2663 – Clubs (♣)

3 -	Deck of Cards
Write a JS function that takes a deck of cards as a string array and prints them as a sequence of cards (space separated). Print "Invalid card: [card]" when an invalid card definition is passed as input. Use the solution from the previous task to generate the cards.

II.Unit Testing

4 -	Sum of Numbers
Your tests will be supplied a function named 'sum'. It needs to meet the following requirements:<br>
•	Takes and array of numbers as argument<br>
•	Returns the sum of the values of all elements inside the array

5 -	Check for Symmetry
Your tests will be supplied a function named 'isSymmetric'. It needs to meet the following requirements:<br>
•	Takes and array as argument<br>
•	Returns false for any input that isn’t of the correct type<br>
•	Returns true if the input array is symmetric (first half is the same as the second half mirrored)<br>
•	Otherwise, returns false

6 -	RGB to Hex
Your tests will be supplied a function named 'rgbToHexColor', which takes three arguments. It needs to meet the following requirements:<br>
•	Takes three integer numbers, representing the red, green and blue values of an RGB color, each within range [0…255]<br>
•	Returns the same color in hexadecimal format as a string (e.g. '#FF9EAA')<br>
•	Returns 'undefined' if any of the input parameters are of invalid type or not in the expected range

7 -	Add / Subtract
Your tests will be supplied a function named 'createCalculator'. It needs to meet the following requirements:<br>
•	Returns a module (object), containing the functions add, subtract and get as properties<br>
•	Keeps an internal sum which can’t be modified from the outside<br>
•	The functions add and subtract take a parameter that can be parsed as a number (either a number or a string containing a number) that is added or subtracted from the internal sum<br>
•	The function get returns the value of the internal sum
