1.	Print Letters
Write a JS function that prints all the symbols of a string, each on a new line.<br>
The input comes as a single string argument.<br>
The output is printed on the console, each letter on a new line.

2.	Concatenate Reversed
Write a JS function that reverses a series of strings and prints them concatenated from last to first.<br>
The input comes as an array of strings.<br>
The output is printed on the console. Print all strings concatenated on a single line, starting from the last input string, going to the first. Reverse each individual string’s letters.

3.	Count Occurrences
Write a JS function that counts how many times a string occurs in a given text. Overlapping strings are allowed.<br>
The input comes as two string arguments. The first element is the target string and the second element is the text in which to search for occurrences.<br>
The output should be a number, printed on the console.

4.	Extract Text
You will be given a text as a string. Write a JS function that extracts and prints only the text that’s surrounded by parentheses.<br>
The input comes as a single string argument.<br>
The output is printed on the console on a single line, in the form of a comma-separated list.

5.	Aggregate Table
You will be given a list of towns and incomes for each town, formatted in a table, separated by pipes (|). Write a JS function that extracts the names of all towns and produces a sum of the incomes. Note that splitting may result in empty string elements and the number of spaces may be different in every table.<br>
The input comes as array of string elements. Each element is one row in a formatted table.<br>
The output is printed on the console on two lines. On the first line, print a comma-separated list of all towns and on the second, the sum of all incomes.

6.	Restaurant Bill
You are tasked to write a JS function that receives an array of purchases and their prices and prints all your purchases and their total sum.<br>
The input comes as an array of string elements – the elements on even indexes (0, 2, 4…) are the product names, while the elements on odd indexes (1, 3, 5…) are the corresponding prices.<br>
The output should be printed on the console - a single sentence containing all products and their total sum in the format “You purchased {all products separated by comma + space} for a total sum of {total sum of products}”.

7.	Usernames
Write a JS function that parses a list of emails and returns a list of usernames, generated from them. Each username is composed from the name of the email address, a period and the first letter of every element in the domain name. See the examples for more information.<br>
The input comes as array of string elements. Each element is an email address.<br>
The output is printed on the console on a single line as a comma-formatted list.

8.	Censorship
The thought police are at it again and they need your help! Write a JS function that would censor news articles. You will be given a text and then a list of strings that need to be blacked out from the text. Replace all occurrences of the strings with dashes of the same length as the string. The strings will not overlap, so order of processing is not important. See the examples for more information.<br>
The input comes as two arguments – one string and one array of strings. The first element is the text to scan and the array contains the strings to be censored.<br>
The output is the return value of your functions. Save the censored results in a string and return it.

9.	Escaping
You will be given a list of strings, containing user-submitted data. Write a JS function that prints an HTML list from the data. The strings, however, may contain special HTML characters, which is an oft-used method for injection attacks. To prevent unwanted behavior or harmful content, all special characters need to be replaced with their encoded counterparts – they will look the same to the user, but will not pose a security risk.<br>
Use the provided HTML template to visually test your code – if you don’t escape the control characters, formatted HTML will show up. Don’t care how the HTML template works. Your job is to write the JS escaping function only.<br>
The input comes as array of string elements.<br>
The output is the return value of your function. Compose the list in a string and return it. See the examples for formatting details.

10.	Match All Words
Write a JS function that matches all words in a text, a word is anything that consists of letters, numbers or underscores (_).<br>
The input comes as single string argument – the text from which to extract the words.<br>
The output should be printed on the console and should consist of all words concatenated with a “|“(pipe), check the examples bellow to better understand the format.

11.	Simple Email Validation
Write a JS function that validates simple emails. The emails should have a username, which consists only of English alphabet letters and digits, a “@” sign, and a domain name after it. The domain should consist only of 2 strings separated by a single dot. The 2 strings should contain NOTHING but lowercase English alphabet letters.<br>
The input comes as single string argument which is an email. <br>
The output should be printed on the console. If the given email is valid, print “Valid”, if it is not, print “Invalid”.

12.	*Expression Split
Write a JS function that splits a passed in JS code into separate parts. The passed in code will always have one or more spaces between operators and operands. Normal brackets (‘(‘,’)’), commas (,), semicolons (;) and the member access operator (‘.’(dot), as in “console.log”) should also be used for splitting. String literals will always be initialized with double quotes (") and will contain only letters. Make sure there are no empty entries in the output.<br>
The input comes as a single string argument - the JS code that has to be split.<br>
The output should be printed on the console, with each elements obtained from the split is printed on a new line.

13.	Match the Dates
Write a JS function that finds and extracts all the dates in the given sentences. The dates should be in format <br>
d-MMM-yyyy. Example: 12-Jun-1999, 3-Dec-2017.<br>
The input comes as an array of strings. Each string represents a sentence.<br>
The output should be printed on the console. The output should consist of all extracted VALID dates. Each element should be printed on a new line.

14.	Parse the Employee Data
Write a JS function that validates employee data, and stores it if it is valid. The employee data consists of 3 elements – employee name, employee salary and employee position.<br>
The input comes as an array of strings. Each element represents input employee data. You should capture only the valid from them. The input will have the following format:<br>
{employeeName} - {employeeSalary} - {employeePosition}<br>
The Employee name will be a string, which can contain only English alphabet letters and must start with a capital. The Employee salary should be a VALID number. The employee position can contain English alphabet letters, digits, dashes, and can consist of several words. Any input that does NOT follow the specified above rules, is to be treated as invalid, and is to be ignored.<br>
The output should be printed on the console. For every valid employee data found, you should print each of its elements. Check the examples.

15.	Form Filler
Write a JS function that automatically fills a form for a lazy client. The client will give you 3 elements of data about himself – his username, his email, and his phone number. After those 3 elements you will be given the form, as text, with several placeholders in it. You must replace each valid placeholder with its corresponding value. The placeholders have special symbols and can contain only English alphabet letters. There are 3 types of valid placeholders:<br>
•	<!{letters}!> - put the given username in place of this<br>
•	<@{letters}@> - put the given email in place of this<br>
•	<+{letters}+> - put the given email in place of this<br>
The input comes as four string arguments and an array of strings. The first 3 arguments will represent the username, the email and the phone number. Each element of the array will represent a sentence, if you find a placeholder somewhere in those sentences you should replace it.<br>
The output should be printed on the console. The output should consist of all sentences, printed again, this time with their placeholders replaced with the actual data.

16.	*Match Multiplication
You are given a text with numbers multiplied by * in format {num1} * {num2}. Your job is to extract each two numbers in the above format, multiply them and replace them with their product. The first number is integer, can be negative. The second number is integer or floating-point and can be negative. There could be whitespace around the “*” symbol.<br>
The input comes as a single string argument – the text holding the numbers.<br>
The output should be printed on the console – it consists of the same text with the multiplied numbers replaced by their product.
