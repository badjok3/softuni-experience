1.	Count Working Days
Write a program that reads two dates in format dd-MM-yyyy and prints the number of working days between these two dates inclusive. Non-working days are:<br>
•	All days that are Saturday or Sunday.<br>
•	All days that are official holidays in Bulgaria:<br>
o	New Year Eve (1 Jan)<br>
o	Liberation Day (3 March)<br>
o	Worker’s day (1 May)<br>
o	Saint George’s Day (6 May)<br>
o	Saints Cyril and Methodius Day (24 May)<br>
o	Unification Day (6 Sept)<br>
o	Independence Day (22 Sept)<br>
o	National Awakening Day (1 Nov)<br>
o	Christmas (24, 25 and 26 Dec)<br>
All days not mentioned above are working and should count.

2.	Advertisement Message
Write a program that generate random fake advertisement message to extol some product. The messages must consist of 4 parts: laudatory phrase + event + author + city. Use the following predefined parts:<br>
•	Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}<br>
•	Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}<br>
•	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}<br>
•	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}<br>
The format of the output message is: {phrase} {event} {author} – {city}.<br>
As an input you take the number of messages to be generated. Print each random message at a separate line.

3.	Intersection of Circles
Create class Circle with properties Center and Radius. The center is a point with coordinates X and Y (make a class Point). Write a method bool Intersect(Circle c1, Circle c2) that tells whether the two given circles intersect or not. Write a program that tells if two circles intersect.
The input lines will be in format: {X} {Y} {Radius}. Print as output “Yes” or “No”.

4.	Average Grades
Define a class Student, which holds the following information about students: name, list of grades and average grade (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a list of students and print the students that have average grade ≥ 5.00 ordered by name (ascending), then by average grade (descending). Print the student name and the calculated average grade.

5.	Book Library 
To model a book library, define classes to hold a book and a library. The library must have a name and a list of books. The books must contain the title, author, publisher, release date, ISBN-number and price. 
Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.

6.	Book Library Modification
Use the classes from the previous problem and make a program that read a list of books and print all titles released after given date ordered by date and then by title lexicographically. The date is given if format “day-month-year” at the last line in the input.

7.	Andrey and billiard
Andrey is the guy who gives us food and drinks at the game bar. He likes to play billiard. Since you are nice guy you want to help him play more of his favorite game. You decide to create a program which will help him to take orders faster and generate billing information. 
First you will receive an integer - the amount of entities with prices (separated by "-"). Then you will receive a list of client. For every consumer you will receive what to buy and how much. When you receive a command: "end of clients" you should display information about every client described below. After that say how much total money were spent while Andrey was playing billiard.

8.	Mentor group
You are mentor of a group. You have done your job well and now you have to generate a report about your group's activity. You will be given usernames and dates ("dd/MM/yyyy"), dates (if any) are separated with comma, until you receive command "end of dates". After that you will receive user and some comment (separated with dash). You can add comment for every user who is in your group (if not ignore the line). Adding comment/date to same user more than once should append to that user the comment/date. Upon receiving command "end of comments" you should generate report in format:<br>
{user} -<br>
Comments:<br>
- {firstComment} …<br>
Dates attended:<br>
-- {firstDate}<br>
-- {secondDate}<br>
Users should be printed ordered by name (ascending). For every user dates should be sorted again in ascending order. Input will be valid for in the format described - you should not check it explicitly!

9.	Teamwork projects
It's time for teamwork projects and you are responsible for making the teams. First you will receive an integer - the count of the teams you will have to register. You will be given a user and a team (separated with "-").  The user is the creator of that team. For every newly created team you should print a message: "Team {team Name} has been created by {user}!". Next you will receive user with team (separated with "->") which means that the user wants to join that team. Upon receiving command: "end of assignment" you should print every team ordered by members count (descending) and then by name (ascending). For each team you have to print it's members sorted by name (ascending). However there are several rules:<br>
•	If user tries to create a team more than once a message should be displayed: <br>
-	"Team {teamName} was already created!"<br>
•	Creator of a team cannot create another team - message should be thrown: <br>
-	"{user} cannot create another team!"<br>
•	If user tries to join currently non-existing team a message should be displayed: <br>
-	"Team {teamName} does not exist!"<br>
•	Member of a team cannot join another team - message should be thrown:<br>
-	"Member {user} cannot join team {team Name}!"<br>
•	In the end (after teams' report) teams with zero members (with only a creator) should disband. 