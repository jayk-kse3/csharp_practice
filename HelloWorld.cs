/* C# Hello world file */

// C# Library directive
using System;

// Project Namespace
namespace HelloWorld
{
   // Only Class file required in this Project's namespace
   class HelloWorld
   {
      // Main() method - only one required in this example
      public static void main() //(String args[])
      {
         String name = "James";
         Console.WriteLine("\nHello World " + name + "\n");
         
         // Take input when User is finished
         Console.WriteLine("Press any key to exit.");
         Console.ReadKey(); // reads any key of User input
         
      } // end Main() method
   } // end Class
} // end namespace
