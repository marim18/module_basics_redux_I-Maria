
The first thing i did was make an initial plan of how i was going to make the car move until it hit something then turn. My first notes looks like this: Gamefunc{
while (somevariable){
new pos = move(old pos)
If (peek()){
move (new pos);}

 } 
else{
turn() }} 
if goal() {
return "you win"}
i couldnt start on the tasks until i had the basic universal things in place like movement and the map.
Ireworked my tictactoe draw function to sui the map and tried to use image to ascii art softwares but it didnt work out.
chatgpt made a program for it so i could use specific emojis but it didnt work.  I left it on git for fun but can remove it. 
Initially i forgot to add a gitignore so i had to go back and delete some files and add it.
Eventually i gave up on this i had intended to use ideas similar to mastermind but i have wasted too much time.

If my program was running, which it is not due to this error Program.cs(129,4): error CS8803: Top-level statements must precede namespace and type declarations. it would start from a menu were you type a number and it should run the function for the file in each tasks.




## Task 1

For task 1 i create a new car and new map and input starting coordinates and goal cordinates. The car will try to go as far as it can in its direction before switching to another direction in a clockwise fashion. By running the Movechain function it starts what would be the core program and runs it with the input of the new objects.

## task 2-5
I use the same appraoch with new objects for each which would contain the data for the maps and cars. I considered adding some way to not backtrack but if you get stuck somewhere backtracking would be necessary so i did not, because i want this method to work universally. I considered adding soemthing that would prioritize going to the direction of the goal but I am unsure how as the goal constantly changes places. It would maybe be something about prioritizing getting the ypos and xpos numbers for the cars and the goal[,] to be more similar but i am unsure how to do this effectively. As with some corners prioritizing moving in a certain direction can lead you to be stuck. so i left it as it is. My solution might be very simple and chaotic but alot of thought did go into it. 