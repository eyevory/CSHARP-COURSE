# Logic Error 3
### The issue
Because arrays start their index count at 0 (as in 0 = 1st value) and .Length on an array outputs the length starting
the count on first number at 1, using a for loop where the loop amount is based on the array length mismatches when using the variable ex. "i" inside the loop. For example an array consisting of five integers will have index values of 0, 1, 2, 3, 4 and when using it in the for loop with an = with .Length, 
the loop will run with "i" having a value of 5, which is outside the array index.

### The fix
Simply removing the "=" from "<=" in the for loop parameters OR adding - 1 after the numbers.Length fixes the issue. This way the final loop will end up
with "i" having a value of 4, which is the final index of the array.
