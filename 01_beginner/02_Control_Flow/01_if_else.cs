__________________________________________________________________________
/* 
Beginner C#: if / else Statements
Purpose: Learn how to make decisions in C# based on conditions */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  make decisions based on employee information such as age, salary, 
  employment status, and performance. */

__________________________________________________________________________
/* 
1️ Basic if Statement
  What it does: Executes code only when a condition is true
  Why use it: Allows programs to react to data
  Syntax: 
    if (condition)
    {
      code to run;
    }*/
__________________________________________________________________________
/*
Problem: 
  Check if an employee is active

Solution: */
  bool isActive = true;

  if (isActive)
  {
    Console.WriteLine("Employee is active");
  }

/* Explanation:
  The code inside the if block runs only if the condition is true */

__________________________________________________________________________
/*
2 if / else Statement
  What it does: Runs one block if the condition is true, another if false
  Why use it: Handles two possible outcomes
  Syntax:
    if (condition)
    {
      code;
    }
    else
    {
      code;
    } */
__________________________________________________________________________
/*
Problem:
  Determine if an employee is active or inactive

Solution: */
  if (isActive)
  {
    Console.WriteLine("Employee is active");
  }
  else
  {
    Console.WriteLine("Employee is inactive");
  }

/* Explanation:
  Console outputs Employee is active if the employee is set to active,
    otherwise, it outputs Employee is inactive */

__________________________________________________________________________
/*
3 Using comparison values in conditions
  What it does: Compare values in conditions
  Why use it: Makes decisions based on numeric or logical comparisons
 */
__________________________________________________________________________
/*
Problem:
  Check if an employee is eligible for a bonus (salary under 80000)

Solution: */
  double salary = 75000.50;

  if (salary < 80000)
  {
    Console.WriteLine("Employee is eligible for a bonus");
  }
  else
  {
    Console.WriteLine("Employee is not eligible for a bonus");
  }

/*
Explanation:
  < compares numeric values */

__________________________________________________________________________
/*
4 Mulitple Conditions with else if
  What it does: Tests multiple conditions in order
  Why use it: Handles more than two outcomes */
__________________________________________________________________________
/*
Problem:
  Categorize employee performance based on grade

Solution: */
  char grade = 'B';

  if (grade == 'A')
  {
    Console.WriteLine("Excellent performance");
  }
  else if (grade == 'B')
  {
    Console.WriteLine("Good performance");
  }
  else if (grade == 'C')
  {
    Console.WriteLine("Satisfactory performance");
  }
  else
  {
    Console.WriteLine("Needs improvement");
  }

/*
Expected Result:
  Good performance */
__________________________________________________________________________
/*
5 Logical Operators (AND / OR)
  What it does: Combines multiple conditions
  Why use it: Makes more precise decisions */
__________________________________________________________________________
/*
Problem: 
 Check if an employee qualifies for promotion */

/*
Solution: */
  int yearsAtCompany = 3;
  bool hasGoodReviews = true;

  if (yearsAtCompany >= 2 && hasGoodReviews)
  {
    Console.WriteLine("Employee qualifies for promotion");
  }
  else
  {
    Console.WriteLine("Employee does not qualify for promotion");
  }

/*
Expected Result:
  Employee qualifies for promotion */

__________________________________________________________________________
/*
6 Nested if Statements
  What it does: Places one if statement inside another
  Why use it: Handles dependent decisions
  */
__________________________________________________________________________
/*
Problem:
  Check promotion eligibility only if employee is active

Solution: */
  if (isActive)
  {
    if (yearAtCompany >= 2)
    {
      Console.WriteLine("Active employee eligible for promotion");
    }
    else
    {
      Console.WriteLine("Active employee not eligible yet");
    }
  }
  else
  {
    Console.WriteLine("Inactive employee not eligible");
  }

/* 
Explanation: 
  Inner condiitons run only if the outer condition is true */
__________________________________________________________________________
/*
7 Useing if / else without Output
  What it does: Displays different messages based on conditions
  Why use it: Communicates program decisions clearly */
__________________________________________________________________________
/*
Problem:
  Display employee status summary

Solution: */
  string firstName = "Alice";

  if (isActive)
  {
    Console.WriteLine($"{firstName} is currently active."};
  }
  else
  {
    Console.WriteLine($"{firstName} is currently inactive.");
  }

/*
Expected Result: 
  Cutputs to console that Alice is currently acitve or Alice is currently
    inactive depending on her status */

__________________________________________________________________________
/*
Key Rules to Remember
  Conditions must evaluate to true or false
  Comparison uses ==, not =
  Curly braces {} define the code block
  else if is checked only if previous conditions fail
  Logical operators:
    && → AND
    || → OR
  if / else controls program flow */
