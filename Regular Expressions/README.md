1. Replace <a> tag
Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…>…[/URL]. Read an input, until you receive “end” command. Print the result on the console. 

2. Extract emails
Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: <br>
•	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". <br>
•	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 

3. Extract sentences by keyword
Write a program that extracts from a text all sentences that contain a particular word (case-sensitive).<br>
•	Assume that the sentences are separated from each other by the character "." or "!" or "?".<br>
•	The words are separated one from another by a non-letter character.<br>
•	Notе that appearance as substring is different than appearance as word. The sentence “I am a fan of Motorhead” does not contain the word “to”. It contains the substring “to” which is not what we need.<br>
•	Print the result sentence text without the separators between the sentences ("." or "!" or "?").

4. *Valid Usernames
You are part of the back-end development team of the next Facebook. You are given a line of usernames, between one of the following symbols: space, “/”, “\”, “(“, “)”. First you have to export all valid usernames. A valid username starts with a letter and can contain only letters, digits and “_”. It cannot be less than 3 or more than 25 symbols long. Your task is to sum the length of every 2 consecutive valid usernames and print on the console the 2 valid usernames with biggest sum of their lengths, each on a separate line. 
