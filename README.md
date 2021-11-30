# Mars Rovers

NASA intends to land robotic rovers on Mars to explore a particularly curious-looking plateau. The rovers must 
navigate this rectangular plateau in a way so that their on board cameras can get a complete image of the 
surrounding terrain to send back to Earth. 

A simple two-dimensional coordinate grid is mapped to the plateau to aid in rover navigation. Each point on the grid is 
represented by a pair of numbers X Y which correspond to the number of points East or North, respectively, from the 
origin. The origin of the grid is represented by 0 0 which corresponds to the southwest corner of the plateau. 0 1 is 
the point directly north of 0 0, 1 1 is the point immediately east of 0 1, etc. A rover’s current position and heading are 
represented by a triple X Y Z consisting of its current grid position X Y plus a letter Z corresponding to one of the four 
cardinal compass points, N E S W. For example, 0 0 N indicates that the rover is in the very southwest corner of the 
plateau, facing north.

NASA remotely controls rovers via instructions consisting of strings of letters. Possible instruction letters are L, R, 
and M. L and R instruct the rover to turn 90 degrees left or right, respectively (without moving from its current spot), 
while M instructs the rover to move forward one grid point along its current heading.
Your task is write an application that takes the test input (instructions from NASA) and provides the expected output 
(the feedback from the rovers to NASA). Each rover will move in series, i.e. the next rover will not start moving until 
the one preceding it finishes. 

## Brief explanation of the solution

Based on the information, We can determine that South and North correspond to Y axis and West and East correspond to X axis.
With that porpose, I created a class named "Cardinal" to handle the cardinal axies, asociate the neighbors around a cardinal point 
like for example North: his left is West and right is East and give values like +1 if it's North and -1 if it's South. 
This way we can achieve the objetives of the NASA to give instructions to the rovers. The second I've created was the "Rover" class 
which interact directly with a list of the Cardinal class with the information previously listed. This way we can simply give instructions 
and get the appropiate cardinal point in the list and get the values and neighbors depends on the instructions. 
Finally, I developed a simple console menu to set the current position and give instructions.

- Rover class is the Aggregate class which connects the other to do the validation and calculations.
- Other classes like Cardinal and CardinalList should be threated like value object classes used on the aggregate class (Rover)
- Because the simplicity of the problem, only two layer were needed: Application Layer and Domain Layer


