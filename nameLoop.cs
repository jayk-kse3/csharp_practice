/* C# Practice - Variables & Control */

using System;

namespace VarControl
{
   class nameLoop
   {
      public static void main()
      {
         // Declarations
         string names[5] = {"Bill", "Tom", "Jim", "Niamh", "Luke", "Sally"};
         
         int count = 0;
         
         Console.WriteLine("------------------------------------");
         Console.Write("Current Team Members\n");
         Console.WriteLine("------------------------------------");
         
         foreach (string name in names)
         {
            count += 1;
            Console.Write("No.\t\t" + "Name\n");
            Console.WriteLine(count + "\t\t" + name);
         } // end Foreach
         
         // Output the latest Counter value following Foreach loop termination
         Console.WriteLine("The counter is now at " + count);
         
      } // end Main
   } // end Class
} // end Namespace
