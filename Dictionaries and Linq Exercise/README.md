1.	Phonebook
Write a program that receives some info from the console about people and their phone numbers. Each entry should have just one name and one number (both of them strings). <br>
On each line you will receive some of the following commands: <br>
•	A {name} {phone} – adds entry to the phonebook. In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.<br>
•	S {name} – searches for a contact by given name and prints it in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist.".<br>
•	END – stop receiving more commands.

2. Phonebook Upgrade
Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the command “ListAll”.

3.	A Miner Task
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to collect the resources and print them each on a new line.<br> 
Print the resources and their quantities in format:<br>
{resource} –> {quantity}<br>
The quantities inputs will be in the range [1 … 2 000 000 000]

4.	Fix Emails
You are given a sequence of strings, each on a new line, until you receive the “stop” command. The first string is the name of a person. On the second line you will receive their email. Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). Print: <br>
{name} – > {email} 

5.	Hands of Cards
You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format: <br>
{personName}: {PT, PT, PT,… PT} <br>
Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. The input will always be valid and in the format described, there is no need to check it.<br>
A single person cannot have more than one card with the same power and type, if he draws such a card he discards it. The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type. Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).<br>
Finally print out the total value each player has in his hand in the format:<br>
{personName}: {value}

6.	* User Logs
Marian is a famous system administrator. The person to overcome the security of his servers has not yet been born. However, there is a new type of threat where users flood the server with messages and are hard to be detected since they change their IP address all the time. Well, Marian is a system administrator and is not so into programming. Therefore, he needs a skillful programmer to track the user logs of his servers. You are the chosen one to help him!<br>
You are given an input in the format:<br>
IP=(IP.Address) message=(A&sample&message) user=(username)<br>
Your task is to parse the IP and the username from the input and for every user, you have to display every IP from which the corresponding user has sent a message and the count of the messages sent with the corresponding IP. In the output, the usernames must be sorted alphabetically while their IP addresses should be displayed in the order of their first appearance. The output should be in the following format:<br>
username: <br>
IP => count, IP => count.<br>
For example, given the following input - IP=192.23.30.40 message='Hello&derps.' user=destroyer, you have to get the username destroyer and the IP 192.23.30.40 and display it in the following format:<br>
destroyer: <br>
192.23.30.40 => 1.<br>
The username destroyer has sent a message from IP 192.23.30.40 once.
