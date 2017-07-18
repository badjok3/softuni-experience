1.	 Heroic Inventory
In the era of heroes, every hero has his own items which make him unique. Create a function which creates a register for the heroes, with their names, level, and items, if they have such. The register should accept data in a specified format, and return it presented in a specified format. <br>
The input comes as array of strings. Each element holds data for a hero, in the following format:<br>
“{heroName} / {heroLevel} / {item1}, {item2}, {item3}...” <br>
You must store the data about every hero. The name is a string, the level is a number and the items are all strings.<br>
The output is a JSON representation of the data for all the heroes you’ve stored. The data must be an array of all the heroes. Check the examples for more info.

2.	JSON’s Table
JSON’s Table is a magical table which turns JSON data into an HTML table. You will be given JSON strings holding data about employees, including their name, position and salary. You need to parse that data into objects, and create an HTML table which holds the data for each employee on a different row, as columns. <br>
The name and position of the employee are strings, the salary is a number.<br>
The input comes as array of strings. Each element is a JSON string which represents the data for a certain employee.<br>
The output is the HTML code of a table which holds the data exactly as explained above. Check the examples for more info.

3.	Cappy Juice
You will be given different juices, as strings. You will also receive quantity as a number. If you receive a juice, you already have, you must sum the current quantity of that juice, with the given one. When a juice reaches 1000 quantity, it produces a bottle. You must store all produced bottles and you must print them at the end.<br>
Note: 1000 quantity of juice is one bottle. If you happen to have more than 1000, you must make as much bottles as you can, and store what is left from the juice.<br>
Example: You have 2643 quantity of Orange Juice – this is 2 bottles of Orange Juice and 643 quantity left.<br>
The input comes as array of strings. Each element holds data about a juice and quantity in the following format:<br>
“{juiceName} => {juiceQuantity}”<br>
The output is the produced bottles. The bottles are to be printed in order of obtaining the bottles. Check the second example bellow - even though we receive the Kiwi juice first, we don’t form a bottle of Kiwi juice until the 4th line, at which point we have already create Pear and Watermelon juice bottles, thus the Kiwi bottles appear last in the output.

4.	Store Catalogue
You have to create a sorted catalogue of store products. You will be given the products’ names and prices. You need to order them by alphabetical order. <br>
The input comes as array of strings. Each element holds info about a product in the following format:<br>
“{productName} : {productPrice}”<br>
The product’s name will be a string, which will always start with a capital letter, and the price will be a number. You can safely assume there will be NO duplicate product input. The comparison for alphabetical order is case-insensitive.<br>
As output you must print all the products in a specified format. They must be ordered exactly as specified above. The products must be divided into groups, by the initial of their name. The group’s initial should be printed, and after that the products should be printed with 2 spaces before their names. For more info check the examples.

5.	Auto-Engineering Company
You are tasked to create a register for a company that produces cars. You need to store how many cars have been produced from a specified model of a specified brand.<br>
The input comes as array of strings. Each element holds information in the following format:<br>
“{carBrand} | {carModel} | {producedCars}”<br>
The car brands and models are strings, the produced cars are numbers. If the car brand you’ve received already exists, just add the new car model to it with the produced cars as its value. If even the car model exists, just add the given value to the current one.<br>
As output you need to print – for every car brand, the car models, and number of cars produced from that model. The output format is:<br>
“{carBrand}<br>
  ###{carModel} -> {producedCars}<br>
  ###{carModel2} -> {producedCars}<br>
  ...”<br>
The order of printing is the order in which the brands and models first appear in the input. The first brand in the input should be the first printed and so on. For each brand, the first model received from that brand, should be the first printed and so on. 

6.	System Components
You will be given a register of systems with components and subcomponents. You need to build an ordered database of all the elements that have been given to you.<br>
The elements are registered in a very simple way. When you have processed all of the input data, you must print them in a specific order. For every System you must print its components in a specified order, and for every Component, you must print its Subcomponents in a specified order.<br>
The Systems you’ve stored must be ordered by amount of components, in descending order, as first criteria, and by alphabetical order as second criteria. The Components must be ordered by amount of Subcomponents, in descending order.<br>
The input comes as array of strings. Each element holds data about a system, a component in that system, and a subcomponent in that component. If the given system already exists, you should just add the new component to it. If even the component exists, you should just add the new subcomponent to it. The subcomponents will always be unique. The input format is:<br>
“{systemName} | {componentName} | {subcomponentName}” <br>
All of the elements are strings, and can contain any ASCII character. The string comparison for the alphabetical order is case-insensitive.<br>
As output you need to print all of the elements, ordered exactly in the way specified above. The format is:<br>
“{systemName}<br>
 |||{componentName}<br>
 |||{component2Name}<br>
 ||||||{subcomponentName}<br>
 ||||||{subcomponent2Name}<br>
 {system2Name} <br>
 ...”

7.	Usernames
You are tasked to create a catalogue of usernames. The usernames will be strings that may contain any ASCII character. You need to order them by their length, in ascending order, as first criteria, and by alphabetical order as second criteria. <br>
The input comes as array of strings. Each element represents a username. Sometimes the input may contain duplicate usernames. Make it so that there are NO duplicates in the output.<br>
The output is all of the usernames, ordered exactly as specified above – each printed on a new line.