using System;

namespace ThirdPartyLibrary
{
    public static class Calculator
    {
        public static int Add(int a = 0, int b = 10)
        {
            Console.WriteLine($"Add => a: {a}, b: {b}");
            return a + b;
        }

        public static int Multiply(int a, int b = 10)
        {
            Console.WriteLine($"Multiply => a: {a}, b: {b}");
            return a * b;
        }
    }
}
