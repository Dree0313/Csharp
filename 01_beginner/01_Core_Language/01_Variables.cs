__________________________________________________________________________
/* 
Beginner C#: Variables
Purpose: Learn how to store and use data in C# */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  store and work with employee information such as names, ages, salaries,
  and employment status.

__________________________________________________________________________
/* 
1️ Declaring Variables
  What it does: Creates a named storage location for data
  Why use it: Allows the program to remember values
  Syntax: dataType variableName;*/
__________________________________________________________________________
/*
Problem: 
  Store an employee's age

Solution: */
  int age;

/* Explanation:
  int = data type
  age = variable name */

__________________________________________________________________________
/*
2 Declaring and Initializing Variables
  What it does: Creates a variable and assigns a value
  Why use it: Most common way to work with data
  Syntax: dataType variableName = value; */
__________________________________________________________________________
/*
Problem:
  Store an employee's first name

Solution: */
  string firstName = "Alice";

/*
Expected Result:
  firstName contains "Alice"*/

__________________________________________________________________________
/*
3 Common Primitive Data Types
  What it does: Represents basic kinds of data
  Why use it: Different data needs different types */
__________________________________________________________________________
/*
Examples: */
  int employeeID = 101;
  double salary = 75000.50;
  bool isActive = true;
  char grade = 'A';

/*
Explanation:
  int → while numbers
  double → decimal numbers
  bool → true / false
  char → single character */

__________________________________________________________________________
/*
4 Updating Variable Values
  What it does: Changes the value stored in a variable
  Why use it: Data often changes during program execution
  Syntax: variableName = newValue; */
__________________________________________________________________________
/*
Problem:
  The employee gets a raise

Solution: */
  salary = 80000.00;

/*
Expected Result:
  salary now contains 80000.00 */
__________________________________________________________________________
/*
5 Using Variables in Output
  What it does: Displays variable values
  Why use it: Helps verify data and show results
  Syntax: Console.WriteLine(...) */
__________________________________________________________________________
/*
Problem:
  Display employee's name and salary

Solution: */
  Console.WriteLine(firstName);
  Console.WriteLine(salary);

/*
Expected Result: */
  Alice
  80000

__________________________________________________________________________
/*
6 String Interpolation
  What it does: Inserts variable values into strings
  Why use it: Cleaner and more readable output
  Syntax: $"Text {variable}" */
__________________________________________________________________________
/*
Problem:
  Display a readable employee summary

Solution: */
  Console.WriteLine($"Employee: {firstName}, Salary: {salary}");

/*
Expected Result:
  Employee: Alice, Salary: 80000 */
__________________________________________________________________________
/*
7 var Keyword (Type Inference)
  What it does: Lets C# infer the variable type
  Why use it: Reduces repetition when the type is obvious
  Syntax: var variableName = value */
__________________________________________________________________________
/*
Problem:
  Store the department name without repeating the type

Solution: */
  var department = "HR";

/*
Expected Result: 
  C# infers department is a string
  Type is still fixed at compile time */

__________________________________________________________________________
/*
Key Rules to Remember
  Variables must be declared before use
  Variable types cannot change after declaration
  Variable names should be descriptive
  C# is strongly typed */

  
