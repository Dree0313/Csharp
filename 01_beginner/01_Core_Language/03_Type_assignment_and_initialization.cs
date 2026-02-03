__________________________________________________________________________
/* 
Beginner C#: Type Assignment and Initialization
Purpose: Learn how to assign values to variables and initialize them 
  properly in C# */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  assign and initialize employee information, including age, salary, 
  employment status, performance grade, and department. */

__________________________________________________________________________
/* 
1️ Assigning a Value to an Existing Variable
  What it does: Stores or updates a value in a previously declared 
    variable
  Why use it: Allows programs to change data during execution
  Syntax: variableName = value;*/
__________________________________________________________________________
/*
Problem: 
  An employee gets a raise. Update their salary.

Solution: */
  double salary;
  salary = 75000.50; // initial assignment
  salary = 80000.00; // updated value

/* Explanation:
  Rirst we assign a value to the variable
  Later we can changed it as needed */

__________________________________________________________________________
/*
2 Declaring and Initializing in One Step
  What it does: Creates a variable and assigns it a value immediately
  Why use it: Most common and concise way to work with variables
  Syntax: dataType variableName = value; */
__________________________________________________________________________
/*
Problem:
  Store an employee's first name at the same time as delaring the variable

Solution: */
  string firstName = "Alice";

/*
Expected Result:
  firstName contains "Alice" */

__________________________________________________________________________
/*
3 Multiple Variables of the Same Type
  What it does: Declares and initializes multiple variables on one line
  Why use it: Saves space and keeps related data together
  Syntax: dataType var1 = value1, var2 = value2; */
__________________________________________________________________________
/*
Problem:
  Store two employees' ages on a single line

Solution: */
  int age1 = 28, age2 = 35;

/*
Expected result:
  age1= 28
  age2 = 35*/

__________________________________________________________________________
/*
4 Using var for Type Inference
  What it does: Lets C# infer the type of a variable from its initial 
    value
  Why use it: Reduces redundancy, especially for long type names
  Syntax: var variableName = value; */
__________________________________________________________________________
/*
Problem:
  Store the department name without explicitly writing 'string'

Solution: */
  var department = "HR";

/*
Expected Result:
  department is inferred as string
  Type is still fixed at compile time*/
__________________________________________________________________________
/*
5 Updating Multiple Types
  What it does: Assign new values to variables of different types
  Why use it: Data often changes, reflecting real-world updates */
__________________________________________________________________________
/*
Example: */
  int employeeId = 101;
  string title = "Developer";
  double bonus = 5000.00;
  bool isActive = true;

// Update values
  title = "Senior Developer;
  bonus = 7500.00;
  isActive = false;

/*
Explanation:
  You can reassign values as long as the type matches */

__________________________________________________________________________
/*
6 Outputting Initialized Variables
  What it does: Shows assignment values on the console
  Why use it: Verify that assignment and initialization worked correctly 
  */
__________________________________________________________________________
/*
Problem:
  Display employee information after updtes

Solution: */
  Console.WriteLine(employeeID);
  Console.WriteLine(firstName);
  Console.WriteLine(title);
  Console.WriteLine(bonus);
  Console.WriteLine(isActive);

//Expected Result: 
  101
  Alice
  Senior Developer
  7500
  False
__________________________________________________________________________
/*
7 String Interpolation with Initialized Variables
  What it does: Combines assigned values into a readable summary
  Why use it: Professional and concise output */
__________________________________________________________________________
/*
Problem:
  Display a summary of employee details

Solution: */
  Console.WriteLine($"Employee {employeeId): {firstName}, Title: {title}, Bonus: {bonus}, Active: {isActive}");

//Expected Result: 
  Employee 101: Alice, Title: Senior Developer, Bonus: 7500, Active: False

__________________________________________________________________________
/*
Key Rules to Remember
  Variables must be declared before use
  You can assign a value later or initilize immediately
  Once declared, the variable's type cannot change
  Using var lets C# infer the type, but the type is fixed after 
    initialization
  Reassign values freely as long as the type matches
  Proper initialization avoids runtime errors */
