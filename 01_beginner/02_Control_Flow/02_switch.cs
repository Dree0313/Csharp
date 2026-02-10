__________________________________________________________________________
/* 
Beginner C#: switch Statements
Purpose: Learn how to handle multiple fixed conditions cleanly and 
  efficiently using switch statements */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior C# developer at a company. Your application needs to 
  respond differently based on employee performance grades, department
  codes, or menu selections. */

__________________________________________________________________________
/* 
1️ What is a switch Statement
  What it does: Selects one code block to run based on a value
  Why use it: Cleaner and more readable thatn many else if statements
  Syntax: 
    switch (value)
    {
      case value1:
        code;
        break;
      default:
        code;
        break;
    }*/
__________________________________________________________________________
/*
Problem: 
  Display a message based on an employee's performance grade

Solution: */
  char grade = 'B';

  switch (grade)
  {
    case 'A':
      Console.WriteLine("Excellent performance");
      break;

    case 'B':
      Console.WriteLine("Good performance");
      break;

    case 'C':
      Console.WriteLine('Satisfactory performance");
      break;

    default:
      Console.WriteLine("Needs improvement");
      break;
  }

/* Explanation:
  switch compares the value against each case
  break prevents execution from continuing to other cases */

__________________________________________________________________________
/*
2 switch vs else if
  What it does: Replaces long else if chains when checking one value
  Why use it: Improves readability and maintainability */
__________________________________________________________________________
/*
Problem:
  Handle employee department codes

Solution: */
  string department = "HR";
  
  switch (department)
  {
    case "HR":
      Console.WriteLine("Human Resources Department");
      break;

    case "IT":
      Console.WriteLine("Information Technology Department");
      break;

    case "FIN":
      Console.WriteLine("Finance Department");
      break;

    default:
      Console.WriteLine("Unknown Department");
      break;
  }

/* Explanation:
  Human Resources Department
  switch is ideal when comparing ONE variable to MANY fixed values */

__________________________________________________________________________
/*
3 Using defaut Case
  What it does: Runs when no code matches
  Why use it: Acts like the final else
 */
__________________________________________________________________________
/*
Problem:
  Handle invalid employee grade

Solution: */
  char employeeGrade = 'Z';

  switch (employeeGrade)
  {
    case 'A':
      Console.WriteLine("Top performer");
      break;

    case 'B':
      Console.WriteLine("Strong performer");
      break;

    case 'C':
      Console.WriteLine("Average performer");
      break;

    default:
      Console.WriteLine("Invalid grade entered");
      break;
  }

/*
Explanation:
  Invalid grade entered */

__________________________________________________________________________
/*
4 Mulitple Cases with the Same Result
  What it does: Groups cases that run the same code
  Why use it: Reduces duplicate code */
__________________________________________________________________________
/*
Problem:
  Treat grade D and F as failing

Solution: */
  char finalGrade = 'D';

  switch (finalGrade)
  {
    case 'A':
      Console.WriteLine("Outstanding");
      break;

    case 'B':
      Console.WriteLine("Good");
      break;

    case 'C':
      Console.WriteLine("Pass");
      break;

    case 'D':
    case 'F':
      Console.WriteLine("Fail");
      break;

    default:
      Console.WriteLine("Invalid grade");
      break;
  }

/*
Expected Result:
  Fail
  Multiple cases can share the same code block */
__________________________________________________________________________
/*
5 switch with Numbers
  What it does: Works with int values
  Why use it: Common for menus and options */
__________________________________________________________________________
/*
Problem: 
 Handle a menu selection */

/*
Solution: */
  int menuOption = 2;

  switch (menuOption)
  {
    case 1:
      Console.WriteLine("View employee list");
      break;

    case 2:
      Console.WriteLine("Add new employee");
      break;

    case 3:
      Console.WriteLine("Delete employee");
      break;

    default:
      Console.WriteLine("Invalid menu option");
      break:
  }

/*
Expected Result:
  Add new employee */

__________________________________________________________________________
/*
6 switch Without break (Fall-Through Prevention)
  What it does: Ensures only one case executes
  Why use it: Prevents accidental execution of multiple cases
  */
__________________________________________________________________________
/* 
Explanation: 
  In C#, break is REQUIRED for non-empty cases
  This prevents bugs common in other languages */
__________________________________________________________________________
/*
7 switch for Clean Output Logic
  What it does: Separates decision logic from output
  Why use it: Keeps code readable and professional */
__________________________________________________________________________
/*
Problem:
  Display employee status based on status code

Solution: */
  int statusCode = 1;
  string statusMessage;

  switch (statusCode)
  {
    case 1:
      statusMessage = "Active";
      break;

    case 2:
      statusMessage = "On Leave";
      break;

    case 3:
      statusMessage = "Terminated";
      break;

    default:
      statusMessage = "Unknown Status";
      break;
  }

  Console.WriteLine($"Employee status: {statusMessage}");
                        
/*
Expected Result: 
  Employee status: Active */

__________________________________________________________________________
/*
Key Rules to Remember
  switch compares ONE value against MANY possible mathces
  Each case must end with break
  default handles unexpected values
  switch is best for fixed, unknown values
  Use if / else for complex logical conditions
  Use switch for clarity and structure */
