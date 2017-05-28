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

7.	* Population Counter
So many people! It’s hard to count them all. But that’s your job as a statistician. You get raw data for a given city and you need to aggregate it. 
On each input line you’ll be given data in format: "city|country|population". There will be no redundant whitespaces anywhere in the input. Aggregate the data by country and by city and print it on the console. For each country, print its total population and on separate lines the data for each of its cities. Countries should be ordered by their total population in descending order and within each country, the cities should be ordered by the same criterion. If two countries/cities have the same population, keep them in the order in which they were entered.

8.	* Logs Aggregator
You are given a sequence of access logs in format <IP> <user> <duration>. Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". Order the users alphabetically. Order the IPs alphabetically. 

9.	* Legendary Farming
You’ve beaten all the content and the last thing left to accomplish is own a legendary item. However, it’s a tedious process and requires quite a bit of farming. Anyway, you are not too pretentious – any legendary will do. The possible items are:<br>
•	Shadowmourne – requires 250 Shards;<br>
•	Valanyr – requires 250 Fragments;<br>
•	Dragonwrath – requires 250 Motes;<br>
Shards, Fragments and Motes are the key materials, all else is junk. You will be given lines of input, such as 
2 motes 3 ores 15 stones. Keep track of the key materials - the first that reaches the 250 mark wins the race. At that point, print the corresponding legendary obtained. Then, print the remaining shards, fragments, motes, ordered by quantity in descending order, then by name in ascending order, each on a new line. Finally, print the collected junk items, in alphabetical order.
