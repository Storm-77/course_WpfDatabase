using System;
using System.Runtime.InteropServices;
using example;
namespace cliTest
{
    class Program
    {
        //[DllImport("Engine.dll")]
        //public static extern int myFunction();
        static void Main(string[] args)
        {
            //var val = myFunction();
            var ex = new example.ManagedClass();
            ex.MethodB("string");
            var val = 34;
            Console.WriteLine($"Hello World! from c#: {val}");
        }
    }
}
