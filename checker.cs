using System;
using System.Diagnostics;

class Checker
{
   static int Main(string[] args) 
    {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
