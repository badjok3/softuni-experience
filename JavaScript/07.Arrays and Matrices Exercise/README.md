I.Arrays

1 -	Print an Array with a given Delimiter
Write a JS function that prints a given array.<br>
The input comes as array of strings. The last element of the array is the delimiter.<br>
The output is the same array, printed on the console, each element separated from the others by the given delimiter.

2 -	Print every N-th Element from an Array 
Write a JS function that prints every element of an array, on a given step.<br>
The input comes as array of strings. The last element is N - the step.<br>
The output is every element on the N-th step starting from the first one. If the step is “3”, you need to print the 1-st, the 4-th, the 7-th … and so on, until you reach the end of the array. The elements must be printed each on a new line.

3 -	*Add and Remove Elements from Array
Write a JS function that adds and removes numbers to / from an array. You will receive a command which can either be “add” or “remove”. <br>
The initial number is 1. Each input command should increase that number, regardless of what it is.<br>

Upon receiving an “add” command you should add the current number to your array. <br>
Upon receiving the “remove” command you should remove the last entered number, currently existent in the array.<br>
The input comes as array of strings. Each element holds a command. <br>
The output is the array itself, with each element printed on a new line. In case of an empty array, just print “Empty”.

4 -	Rotate Array
Write a JS function that rotates an array. The array should be rotated to the right side, meaning that the last element should become the first, upon rotation. <br>
The input comes as array of strings. The last element of the array is the amount of rotation you need to perform.<br>
The output is the resulted array after the rotations. The elements should be printed on one line, separated by a single space.

5 -	Extract an Non-decreasing Subsequence from an Array
Write a JS function that extracts only those numbers that form a non-decreasing subsequence. In other words, you start from the first element and continue to the end of the given array of numbers. Any number which is LESS THAN the current biggest one is ignored, alternatively if it’s equal or higher than the current biggest one you set it as the current biggest one and you continue to the next number. <br>
The input comes as array of numbers.<br>
The output is the processed array after the filtration, which should be a non-decreasing subsequence. Each element should be printed on a new line.

6 -	Sort an Array by 2 Criteria
Write a JS function that orders a given array of strings, by length in ascending order as primary criteria, and by alphabetical value in ascending order as second criteria. The comparison should be case-insensitive.<br>
The input comes as array of strings.<br>
The output is the ordered array of strings.

II.Multidimensional Arrays

7 -	Magic Matrices
Write a JS function that checks if a given matrix of numbers is magical. A matrix is magical if the sums of the cells of every row and every column are equal. <br>
The input comes as an array of arrays, containing numbers (number 2D matrix). The input numbers will always be positive.<br>
The output is a Boolean result indicating whether the matrix is magical or not.

8 -	*Spiral Matrix
Write a JS function that generates a Spirally-filled matrix with numbers, with given dimensions.<br>
The input comes as 2 numbers that represent the dimension of the matrix. <br>
The output is the matrix filled spirally starting from 1. You need to print every row on a new line, with the cells separated by a space. Check the examples below. 
