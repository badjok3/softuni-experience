1.	Sort Array
Write a function that sorts an array with numeric values in ascending or descending order, depending on an argument that’s passed to it.

2.	Argument Info
Write a function that displays information about the arguments which are passed to it – type and value – and a summary about the number of each type.

3.	Functional Sum
Write a function that adds a number passed to it to an internal sum and returns itself with its internal sum set to the new value, so it can be chained in a functional manner. 

4.	Personal BMI
A wellness clinic has contacted you with an offer – they want you to write for them a program that composes patient charts and performs some preliminary evaluation of their condition. The data comes in the form of several arguments, describing a person – their name, age, weight in kilograms and height in centimeters. Your program must compose this information into an object and return it for further processing.<br>
The patient chart object must contain the following properties:<br>
•	name<br>
•	personalInfo, which is an object holding their age, weight and height as properties<br>
•	BMI – body mass index. You can find information about how to calculate it here: https://en.wikipedia.org/wiki/Body_mass_index <br>
•	status<br>
The status is one of the following:<br>
•	underweight, for BMI less than 18.5;<br>
•	normal, for BMI less than 25;<br>
•	overweight, for BMI less than 30;<br>
•	obese, for BMI 30 or more;<br>
Once the BMI and status are calculated, you can make a recommendation. If the patient is obese, add an additional property called recommendation and set it to “admission required”.

5.	Vector Math
Write several functions for preforming calculations with vectors in 2D space  and collect them all in a single object (namespace), so they don’t pollute the global scope. 

6.	Breakfast Robot
It’s finally the future! Robots take care of everything and man has been freed from the mundane tasks of living. There is still work to be done though, since those robots need to be programmed first – we may have robot chefs, but we don’t yet have robot software developers.<br>
Your task is to write the management software for a breakfast chef robot – it needs to take orders, keep track of available ingredients and output an error if something’s wrong. Someone else has already installed the cooking instructions, so your module needs to plug into the system and only take care of orders and ingredients. And since this is the future and food is printed with nano-particle beams, all ingredients are microelements – protein, carbohydrates, fat and flavours. The library of recipes includes the following meals:<br>
•	Apple – made with 1 carb and 2 flavour<br>
•	Coke – made with 10 carb and 20 flavour<br>
•	Burger – made with 5 carb, 7 fat and 3 flavour<br>
•	Omelet – made with 5 protein, 1 fat and 1 flavour<br>
•	Cheverme – made with 10 protein, 10 carb, 10 fat and 10 flavour<br>
The robot receives instructions either to restock the supply, cook a meal or report statistics. The input consists of one of the following commands:<br>
•	restock <microelement> <quantity> – increases the stored quantity of the given microelement<br>
•	prepare <recipe> <quantity> – use the available ingredients to prepare the given meal<br>
•	report – return information about the stored microelements, in the order described below, including zero elements<br>
The robot is equipped with a quantum field storage, so it can hold an unlimited quantity of ingredients, but there is no guarantee there will be enough available to prepare a recipe, in which case an error message should be returned. Their availability is checked in the order in which they appear in the recipe, so the error should reflect the first requirement which wasn’t met.<br>
Submit a closure that returns the management function. The management function must take one parameter.
