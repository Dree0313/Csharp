__________________________________________________________________________
/* 
Beginner C#: foreach Loops
Purpose: Learn how to iterate over each element in a collection using
  foreach */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  process employee records, generate reports, and handle tasks such as
  printing employee names or salaries without worrying about indexes. */

__________________________________________________________________________
/* 
1️ What is a foreach Loop
  What it does: Iterates through each element in a collection (arrays,
    lists, etc.)
  Why use it: Best when you want to access every item in a collection
    without manual indexing
  Syntax: 
    foreach (datatype item in collection)
    {
      code to execute;
    }*/
__________________________________________________________________________
/*
Problem: 
  Print employee names from an array
  
Solution: */
  string[] employees = {"Alice", "Bob", "Cynthia", "David};
  
  foreach (string employee in employee)
  {
  Console.WriteLine(employee);
  }
  
/* 
Expected Result:
  Alice
  Bob
  Cynthia
  David
  
  employee represents the current element in each iteration
  No need for index numbers
*/

__________________________________________________________________________
/*
2 Iterating Through Numbers
  What it does: Uses foreach with collections like arrays or lists of
    numbers
  Why use it: Simplifies processing numeric data without for-loop counters
  */
__________________________________________________________________________
/*
Problem:
  Print numbers 1 through 5

Solution: */
  int[] numbers = {1, 2, 3, 4, 5};
  
  foreach (int number in numbers)
  {
    Console.WriteLine(number);
  }

/* Expected Result:
  1
  2
  3
  4
  5
  
  No need to manually manage start/end or increments */

__________________________________________________________________________
/*
3 Calculations with foreach
  What it does: Performs accumulations or totals while iterating
  Why use it: Simplifies summing or processing each element
 */
__________________________________________________________________________
/*
Problem:
  Calculate total bonus for employees receiving $1000 each

Solution: */
  double totalBonus = 0;
  
  foreach (int employeeId in number)
  {
    totalBonus += 1000;
  }

  Console.WriteLine($"Total Bonus: {totalBonus}");

/*
Explanation:
  Total Bonus: 5000
  
  += adds the value for each iteration */

__________________________________________________________________________
/*
4 Using foreach with Lists
  What it does: Works with any collection type, not just arrays
  Why use it: Common in real-world applications where Lists or other
    collections are used */
__________________________________________________________________________
/*
Problem:
  Print employee names stored in a List

Solution: */
  List<string> employeeList = new List<string> {"Alice", "Bob", "Cynthia", "David"};

  foreach (string emp in employeeList)
  {
   Console.WriteLine(emp);
  }
  
/*
Expected Result:
 Alice
 Bob
 Cynthia
 David
 
  Works the same way as arrays but more flexible */
__________________________________________________________________________
/*
5 Using foreach with Conditional Logic
  What it does: Apply conditions inside the loop
  Why use it: Skip or process specific items easily */
__________________________________________________________________________
/*
Problem: 
 Skip printing employee "Cynthia" */

/*
Solution: */
  foreach(string emp in employeeList)
  {
    if (emp == "Cynthia")
    {
      continue; // Skip this iteration
    }
    Console.WriteLine(emp);
  }

/*
Expected Result:
  Alice
  Bob
  David

  continue skips the rest of the loop body for the element */

__________________________________________________________________________
/*
Key Rules to Remember
  foreach is best when you need to iterate over collections
  No need to manage indexes or loop counters
  The variable represents the current item in the iteration
  Works with arrays, Lists, and other collections
  Can include conditionals with if, and use continue
  Cannot modify the collection while iterating (for that, use for loops or 
    other methods) */
