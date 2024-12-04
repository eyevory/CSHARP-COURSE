# Logic Error 2
### The issue
Since the code uses if statements that only check if the age is above a certain number, it will always print the moment it fulfills the first requirement, meaning it will always print "Over 18" no matter how high the age goes.

### The fix
While keeping the If logic, we can simply add && (AND Operators) to check if the age is both above AND below a certain age to get our age brackets. This allows the elseif statements to be fulfilled depending on input.
