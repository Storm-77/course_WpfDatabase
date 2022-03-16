using System;
using System.Runtime.InteropServices;

namespace cliTest
{
    class Program
    {
        [DllImport("Engine.dll")]
        public static extern int myFunction();
        static void Main(string[] args)
        {
            var val = myFunction();
            Console.WriteLine($"Hello World! from c#: {val}");
        }
    }
}
