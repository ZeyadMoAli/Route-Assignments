using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");

          

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════
            //used to organize and group code into collapsible sections, making large code files easier to navigate and maintain.
            //Nested Region Example

            #region First Region

            #region Second Region

            

            #endregion

            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════
            

            // EXPLICIT DECLARATION 
            //manually specify the data type of the variable when declaring it
            int age = 25;

            // IMPLICIT DECLARATION 
            //You use the keyword var, and the compiler infers the data type automatically from the assigned value at compile time.
            var age2 = 25;  
            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════
            const double pi = 3.14;
            // Constant examples
            // When a value will not change in the program

            #endregion

            #region Question 4: Class-level vs Method-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            
            public class car
            {
                private int price; // class-level scope

                public void PrintPrice()
                {
                    int price = 10000; // method-level scope
                    Console.WriteLine(price);
                }
            }

            #endregion

            #region Question 5: Block-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════

            public void test()
            {
                {
                    int x = 5;
                }
                //x = 10; can't access outside of block
            }

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════

            //Lifetime is how long a variable exists in memory — from creation to destruction.
            // Static: Lives for entire app lifetime
            // Local: Lives until method ends
            
            #endregion

            #region Question 7: Garbage Collector

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════
            // automatic memory management system that frees memory by removing objects that are no longer referenced by the program
            //An object stays in memory as long as it is reachable. When no references remain, the GC marks it as unused and automatically deletes it during a collection cycle, ending its lifetime.

            #endregion

            #region Question 8: Variable Shadowing

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════
            // Shadowing occurs when a variable declared in an inner scope has the same name as one in an outer scope, temporarily "hiding" the outer variable.
            // No C# allows shadowing in nested blocks within the same method.
            #endregion

            #region Question 9: C# Naming Rules

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * Cannot start with a number.
             * Cannot be a C# reserved keyword
             * Can contain only letters, digits, and underscores
             * Case-sensitive
             * Must be unique within its scope
             */
            #endregion

            #region Question 10: Naming Conventions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════

            /*
             * (a) Local variables — camelCase
             * (b) Class names — PascalCase
             * (b) Class names — PascalCase
             */
            #endregion

            #region Question 11: Error Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * Compiler Error Detected by the compiler
             *  int y = 5 
             * Run Time Error Happens while the program is running
             * int x = 10 / 0;
             * Logical Errors Happens when there is wrong in the business logic
             * int sum = 10 + 20 + 30;
             * int avg = sum / 2; 
             */

            #endregion

            #region Question 12: Exception Handling Importance

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════
            
            /*
             * Exception handling in C# is important because it allows your program to detect and manage runtime errors gracefully instead of crashing unexpectedly. It helps maintain stability, protect data, and give meaningful error messages to users.
             */

            #endregion

            #region Question 13: try-catch-finally

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════
            //finally block is always executed regardless of whether an exception is thrown or not.
            try {
                int result = 10 / 0;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Cannot divide by 0");
                }
            finally{
                 Console.WriteLine("Finally block executed");
            }
            #endregion

            #region Question 14: Common Built-in Exceptions

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * NullReferenceException : Occurs when an application attempts to use a null reference, such as when an object reference is not assigned to an object instance.
             * FormatException : Occurs when an application attempts to convert a string to an incompatible format.
             * DivideByZeroException: Occurs when an application attempts to divide a value by zero.
             * IndexOutOfRangeException : Occurs when an application attempts to access an element of an array or collection with an index that is outside the valid bounds of the array or collection.
             * FileNotFoundException : Occurs when an application attempts to open a file that does not exist.
             */
            #endregion

            #region Question 15: Multiple catch Blocks

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════
                /*
                 * The order of catch blocks is important because C# checks them from top to bottom and executes the first matching catch block.
                 * 
                 */
                try
                {
                    int x = int.Parse("abc");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General error");
                }
                catch (FormatException ex)   // Unreachable 
                {
                    Console.WriteLine("Format error");
                }

            #endregion

            #region Question 16: throw Keyword

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * throw is used to raise an exception manually Preserves the original stack trace.
             * throw ex Throws the exception object again as if it were new Resets the stack trace
             * 
             */
            #endregion

            #region Question 17: Stack and Heap Memory

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * The Stack stores method calls and local variables. Memory is allocated and released automatically using LIFO
             * The Heap stores objects created using new. Memory is managed by the Garbage Collector
             */

            #endregion

            #region Question 18: Value Types vs Reference Types

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════
            int x = 10, y = 20;
            y = x;
            x = 50;
            Console.WriteLine(x);
    public class Person
    {
        public string Name;
    }

    Person p1 = new Person();
    p1.Name = "Ali";

    Person p2 = p1;   

    p2.Name = "Omar";

    Console.WriteLine(p1.Name); // Omar
    Console.WriteLine(p2.Name); // Omar


            #endregion

            #region Question 19: Object in C#

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             * it is the root type of the C# type hierarchy,
             * ToString()
             * Equals()
             * GetHashCode()
             * GetType()
             */

            #endregion

        }
        
    }
    
}