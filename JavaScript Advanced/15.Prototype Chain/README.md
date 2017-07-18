1.	Balloons
You have been tasked to create several classes for balloons.<br>
Implement a class Balloon, which is initialized with a color (String) and gasWeight (Number). These two arguments should be public members.<br>
Implement another class PartyBalloon, which inherits the Balloon class and is initialized with 2 additional parameters – ribbonColor (String) and ribbonLength (Number).<br>
The PartyBalloon class should have a property ribbon, which is an object with color and length – the ones given upon initialization. The ribbon property should have a getter.<br>
Implement another class BirthdayBalloon, which inherits the PartyBalloon class and is initialized with 1 extra parameter – text (String). The text should be a property, and should have a getter.

2.	People
Define several JS classes, that represent a company’s employee records. Every employee has a name and age, a salary and a list of tasks, while every position has specific properties not present in the others. Place all common functionality in a parent abstract class. 

3.	Posts
Your need to create several classes for Posts.<br>
Implement a class Post, which is initialized with a title (String) and content (String). The 2 arguments should be public members.<br>
The Post class should also have toString() function which returns the following result:<br>
“Post: {postTitle}”<br>
“Content: {postContent}”<br>
Implement another class which is called SocialMediaPost, which inherits the Post class.<br>
The SocialMediaPost class should be initialized with 2 additional arguments – likes (Number) and dislikes (Number). <br>
The SocialMediaPost class should hold an array of comments (Strings), and a function addComment(comment), which adds comments to that array.<br>
The SocialMediaPost class should extend the toString() function of the Post class, and should return the following result:<br>
“Post: {postTitle}”<br>
“Content: {postContent}”<br>
“Rating: {postLikes – postDislikes}”<br>
“Comments:”<br>
“ * {comment1}”<br>
“ * {comment2}”<br>
. . .<br>
In case there are no comments, return information only about the title, content and rating of the post.<br>
Implement another class which is called BlogPost, which inherits the Post class.<br>
The BlogPost class should be initialized with 1 additional arguments – views (Number).<br>
The BlogPost class should hold a function view(), which increments the views of the object with 1, every time it is called. The function should return the object, so that chaining is supported.<br>
The BlogPost class should extend the toString() function of the Post class, and should return the following result:<br>
“Post: {postTitle}”<br>
“Content: {postContent}”<br>
“Views: {postViews}”

4.	The Elemelons
If Watermelons exist, Firemelons, Earthmelons and Airmelons should also exist. Create classes for The 4 Elemelons.<br>
Create an abstract class for the Elemelons. Name it Melon.<br>
The Melon class should be initialized with weight (Number), and melonSort (String). The 2 arguments should be public members.<br>
Create classes Watermelon, Firemelon, Earthmelon, Airmelon. Each of them should inherit the abstract class Melon and its functionality. Aside from the abstract functionality, each of the Elemelons should have property elementIndex (Number), which is equal to its weight * the string length of its melonSort. The property should have only a getter.<br>
All of the classes should hold a toString() function, which returns the following result for them:<br>
“Element: {Water/Fire/Earth/Air}”<br>
“Sort: {elemelonSort}”<br>
“Element Index: {elemelonElementIndex}”<br>
Create one more class which is called Melolemonmelon, which inherits one of the 4 elemelons, regardless of which. <br>
The Melolemonmelon has no element, but it can morph into any of the others. Implement a function morph(), which changes the current element of the Melolemonmelon, each time it is called. <br>
Upon initialization, the initial element is Water. From then it should go in the following order: Fire, Earth, Air, Water, Fire… and so on.<br>
The toString() function should remain the same as its parent class.
