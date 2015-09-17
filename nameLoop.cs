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
         
         
         foreach (name in names)
         {
            count += 1;
            Console.WriteLine("No\t\t" + "name");
         }
         
      }
   }
}
