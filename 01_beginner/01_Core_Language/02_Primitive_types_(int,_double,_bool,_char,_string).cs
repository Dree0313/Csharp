__________________________________________________________________________
/* 
Beginner C#: Primitive Types
Purpose: Learn the core built-in data types used to store basic values in 
  C#*/
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  store employee information such as age, salary, employment status, 
  performance grade, and name. */

__________________________________________________________________________
/* 
1️ int (Integer)
  What it does: Stores whole numbers
  Why use it: Used for counts, IDs, ages, quantities
  Syntax: int variableName = value;*/
__________________________________________________________________________
/*
Problem: 
  Store an employee's age

Solution: */
  int age = 28;

/* Explanation:
  int stores while numbers only
  No decimals are allowed */

__________________________________________________________________________
/*
2 double (Decimal Numbers)
  What it does: Stores numbers with decimals
  Why use it: Used for money, measurements, percentages
  Syntax: double variableName = value; */
__________________________________________________________________________
/*
Problem:
  Store an employee's salary

Solution: */
  double salary = 75000.50;

/*
Explanation:
  double supports decimal values
  More precise than int */

__________________________________________________________________________
/*
3 bool (Boolean)
  What it does: Stores true or false values
  Why use it: Represents conditions or states
  Syntax: bool variableName = true | false;*/
__________________________________________________________________________
/*
Problem:
  Store whether the employee is currently active

Solution: */
  bool isActive = true;

/*
Explanation:
  bool can ONLY be true or false
  Often used in conditionals */

__________________________________________________________________________
/*
4 char (Character)
  What it does: Stores a single character
  Why use it: Used for grades, initials, codes
  Syntax: char variableName = 'A'; */
__________________________________________________________________________
/*
Problem:
  Store an employee's performance grade

Solution: */
  char grade = 'A';

/*
Explanation:
  char uses single quotes
  Can only hold ONE character */
__________________________________________________________________________
/*
5 string (Text)
  What it does: Stores text (multiple characters)
  Why use it: Used for names, messages, descriptions
  Syntax: string variableName = "text" */
__________________________________________________________________________
/*
Problem:
  Store an employee's first name

Solution: */
  string firstName = "Alice";

/*
Explanation:
  string uses double quotes
  Can store multiple characters */

__________________________________________________________________________
/*
6 Using Primitive Types Together
  What it does: Combines multiple data types in a program
  Why use it: Real applications require different kinds of data */
__________________________________________________________________________
/*
Example: */
  int employeeId = 101;
  string department = "HR";
  double bonus = 5000.00;
  bool eligibleForPromotion = true;

/*
Explanation:
  Each variable uses the type best suited for its data */
__________________________________________________________________________
/*
7 Outputting Primitive Types
  What it does: Displays stored values
  Why use it: Helps verify program behavior */
__________________________________________________________________________
/*
Problem:
  Display all employee information

Solution: */
  Console.WriteLine(firstName);
  Console.WriteLine(age);
  Console.WriteLine(salary);
  Console.WriteLine(isActive);
  Console.WriteLine(grade);

//Expected Result: 
  Alice
  28
  75000.5
  True
  A

__________________________________________________________________________
/*
8 String Interpolation with Primitive Types
  What it does: Combines text and variables into readable output
  Why use it: Cleaner and more professional output */
__________________________________________________________________________
/*
Problem:
  Display a formatted employee summary

Solution: */
  Console.WriteLine($"Employee: {firstName, Age: {age}, Salary: {salary}, Active: {isActive}");

//Expected Result: 
  Employee: Alice, Age: 28, Salary: 75000.5, Active: True
__________________________________________________________________________
/*
Key Rules to Remember
  int → whole numbers only
  double → decimal numbers
  bool → true or false
  char → single character (single quotes)
  string → text (double quotes)
  
  C# is strongly typed
  Each variable's type is fixed at compile time
  Choose the type that best represents the data */
