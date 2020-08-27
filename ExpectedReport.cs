using System;
using System.Diagnostics;

namespace VitalsSimplification
{
   class ExpectedReports
    {
      public static void ExpectTrue(bool expression) 
        {
          if(!expression) 
            {
              Console.WriteLine("Expected true, but got false");
              Environment.Exit(1);
            }
        }
   
      public static void ExpectFalse(bool expression) 
          {
             if(expression) 
              {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
              }
          }
          
     }
}
