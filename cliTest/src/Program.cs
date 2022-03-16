using System;
using System.Runtime.InteropServices;
using example;
namespace cliTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ex = new example.ManagedClass())
            {
                ex.MethodB("string");
            }
            var val = 34;
            Console.WriteLine($"Hello World! from c#: {val}");
        }
    }
}
