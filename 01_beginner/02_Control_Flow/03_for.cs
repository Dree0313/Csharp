__________________________________________________________________________
/* 
Beginner C#: for Loops
Purpose: Learn how to repeat code a specific number of times using for 
  loops */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  process employee records, generate reports, and repeat tasks such as
  printing employee IDs or calculating totals. */

__________________________________________________________________________
/* 
1️ What is a for Loop
  What it does: Repeats a block of code a specific number of times
  Why use it: Best when you know how many times you want to repeat
  Syntax: 
    for (initialization; condition; increment)
    {
      code to repeat;
    }*/
__________________________________________________________________________
/*
Problem: 
  Print employee IDs from 1 to 5

Solution: */
  for (int i = 1; i <= 5; i++)
  {
    Console.WriteLine($"Employee ID: {1}");
  }

/* 
Expected Result:
  1
  2
  3
  4
  5
  
  int i = 1 → starting value
  i <= 5 → loop runs while this is true
  i++ → increases i by 1 each time
  Loop stops when condition becomes false
*/

__________________________________________________________________________
/*
2 Undderstanding the Three Parts
  What it does: Breaks down initialization, condition, and increment
  Why use it: Helps you control loop behavior precisely */
__________________________________________________________________________
/*
Problem:
  Print numbers 0 through 4

Solution: */
  for (int i = 0; i < 5; i++)
  {
    Console.WriteLine(i);
  }

/* Expected Result:
  0
  1
  2
  3
  4
  
  Loop runs while i is LESS than 5 */

__________________________________________________________________________
/*
3 Counting Backwards
  What it does: Decrements instead of increments
  Why use it: Useful for countdowns or reverse processing
 */
__________________________________________________________________________
/*
Problem:
  Countdown from 5 to 1

Solution: */
  for (int i = 5; i >= 1; i--)
  {
    Console.WriteLine(i);
  }

/*
Explanation:
  5
  4
  3
  2
  1
  
  i-- decreases value by 1 each loop */

__________________________________________________________________________
/*
4 Using for with Calculations
  What it does: Performs repeated calculations
  Why use it: Ideal for totals and accumulations */
__________________________________________________________________________
/*
Problem:
  Calculate total bonus payout for 5 employees receiving $1000 each

Solution: */
  double totalBonus = 0;

  for (int i = 1; i <= 5; i++)
  {
   totalBonus += 1000;
  }

  Console.WriteLine($"Total Bonus: {totalBonus}");
/*
Expected Result:
  totalBonus is set to 5000
  += adds values to the existing variable each iteration */
__________________________________________________________________________
/*
5 Looping Through Arrays
  What it does: Accesses each element in a collection
  Why use it: Common for processing employee lists */
__________________________________________________________________________
/*
Problem: 
 Print employee names from an array */

/*
Solution: */
  string[] employees = { "Alice", "Bob", "Cynthia", "David" };

  for (int i = 0; i < employees.Length; i++)
  {
    Console.WriteLine(employees[i]);
  }

/*
Expected Result:
  Alice
  Bob
  Cynthia
  David

  employees.Length gives total number of items
  employees[i] accesses each element by index*/

__________________________________________________________________________
/*
6 Using break in a for Loop
  What it does: Stops the loop early
  Why use it: Ends loop when a condition is met
  */
__________________________________________________________________________
/*
Problem: 
 Stop searching when employee ID 3 is found */

/*
Solution: */
  for (int i = 1; i <= 5; i++)
  {
    if (i == 3)
    {
      Console.WriteLine("Employee Found");
      break;
    {
    Console.WriteLine($"Checking Employee {i}");  
  }

/*
Expected Result:
  Employee Found
  Checking Employee 3
  break immediately exits the loop */

__________________________________________________________________________
/*
7 Using continue in a for Loop
  What it does: Skips current iteration
  Why use it: Ignores specific values */
__________________________________________________________________________
/*
Problem:
  Skip employee ID 3

Solution: */
  for (int i = 1; i <= 5; i++)
  {
    if (i == 3)
    {
      continue;
    )

    Console.WriteLine($"Processing Employee {i}");
  }
                        
/*
Expected Result: 
  Processing Employee 1
  Processing Employee 2
  Processing Employee 4
  Processing Employee 5 
    
  continue skips the rest of the loop body for that iteration */

__________________________________________________________________________
/*
Key Rules to Remember
  for loops are best when you know the number of iterations
  Initialization runs once at the beginning
  Condiiton is checked before every loop cycle
  Increment / decrement runs after each iteration
  Use break to stop early
  Use continue to skip specific iterations
  Be careful of infinite loops (condition must eventually become false)
  for loops are powerful for calculations, arrays, and structured 
    repetition */
