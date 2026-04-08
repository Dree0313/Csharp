__________________________________________________________________________
/* 
Beginner C#: while loop
Purpose: Learn how to repeat code execution while a condition is true */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  process tasks repeatedly, such as checking system status, retrying 
  operations, or looping until a condition is met. */

__________________________________________________________________________
/* 
1️ What is a while Loop
  What it does: Repeats a block of code as long as a condition is true
  Why use it: Best when you don't know exactly how many times you need to
    loop
  Syntax: 
    while (condition)
    {
      code to execute;
    }*/
__________________________________________________________________________
/*
Problem: 
  Print numbers from 1 to 5
  
Solution: */
  int i = 1;
  
  while (i <= 5)
  {
  Console.WriteLine(i);
  i++;
  }
  
/* 
Expected Result:
  1
  2
  3
  4
  5
  
  i++ increments the counter each loop
*/

__________________________________________________________________________
/*
2 Controlling the Loop
  What it does: Uses a condition to determine when the loop stops
  Why use it: Prevents infinite loops and controls execution flow
  */
__________________________________________________________________________
/*
Problem:
  Keep printing until the number reaches 3
  
Solution: */
  int num = 1;
  
  while (num <= 3)
  {
    Console.WriteLine(num);
    num++;
  }

/* Expected Result:
  1
  2
  3
  
  Loop stops once condition becomes false */

__________________________________________________________________________
/*
3 Calculations with while
  What it does: Performs repeated calculations
  Why use it: Useful for totals, counters, or accumulating values
 */
__________________________________________________________________________
/*
Problem:
  Calculate total of numbers from 1 to 5

Solution: */
  int sum = 0;
  int count = 1;
  
  while (count <= 5)
  {
    sum += count;
    count++;
  }

  Console.WriteLine($"Total: {sum}");

/*
Explanation:
  Total: 15
  
  += adds each number to the total */

__________________________________________________________________________
/*
4 Using while with Conditions
  What it does: Allows decision-making inside loops
  Why use it: Helps control behavior dynamically */
__________________________________________________________________________
/*
Problem:
  Prints only even numbers from 1 to 6
  
Solution: */
  int number = 1;

  while (number <= 6)
  {
   if (number % 2 == 0) {
     Console.WriteLine(number);
   }
    number++;
  }
  
/*
Expected Result:
 2
 4
 6
 
  % checkss for remainder (even numbers have 0 remainder) */
__________________________________________________________________________
/*
5 Avoiding Infinite Loops
  What it does: Ensures the loop eventually stops
  Why use it: Prevents your program from running forever */
__________________________________________________________________________
/*
Problem: 
 Fix the infinite loop 

Incorrect Code: */
  int x = 1;
  
  while (x <= 5)
  {
    Console.WriteLine(x);
  }

/*
Solution: */
  int x = 1;

  while (x <= 5)
  {
    Console.WriteLine(x);
    x++; //Important: update the variable
  }

/*
Explanation:
  Without x++, the condition never changes → infinite loop */

__________________________________________________________________________
/*
6 Using break with while
  What it does: Exits the loop early
  Why use it: Stop looping when a condition is met */
__________________________________________________________________________
/*
Problem: 
 Stop the loop when number equals 3

/*
Solution: */
  int value = 1;

  while (value <= 5)
  {
    if (value == 3) {
      break;
    }
    Console.WriteLine(value);
    value++;
  }

/*
Expected Result:
  1
  2
  
  break exits the loop immediately*/

__________________________________________________________________________
/*
Key Rules to Remember
  while loops run aas as long as the condition is true
  Always updated your loop variable to avoid infinite loops
  Best when number of iterations is unknown
  Can use if, break, and continue inside loop
  Condition is checked BEFORE each iteration */
