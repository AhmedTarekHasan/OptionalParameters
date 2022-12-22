using System;
using ThirdPartyLibrary;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int additionResult = Calculator.Add();
            additionResult = Calculator.Add(2);
            additionResult = Calculator.Add(2, 3);

            int multiplicationResult = Calculator.Multiply(2);
            multiplicationResult = Calculator.Multiply(2, 4);

            Console.ReadLine();
        }
    }
}