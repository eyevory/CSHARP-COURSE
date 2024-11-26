#A.15 Logical Error 1 in C#

Inside the for loop is an if statement which checked
if the first index was less than the integer "max", which had a starting value of 0. Since every number inside the array was a positive number, the if statement was never fulfilled, leaving the "max" integer at 0 and printing out 0.

The simple fix was to swap the < for > which makes the code run whenever it encounters a larger number than previously saved to the "max" integer in the array.