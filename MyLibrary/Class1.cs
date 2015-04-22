using System;
using ExcelDna.Integration;

namespace MyLibrary
{
    public class Class1
    {
        [ExcelFunction(Description = "My first Excel-DNA function")]
        public static string MyFirstFunction(string name)
        {
            return "Hello " + name;
        }
    }
}
