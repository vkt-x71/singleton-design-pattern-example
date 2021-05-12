using System;

namespace SingletonDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validation = Validation.Instance;
            validation.EmailRegex = "[A-Za-z0-9]+";
            Validation validation2 = Validation.Instance;
            Console.WriteLine($"Test text {validation2.EmailRegex}");
            Console.Read();
        }
    }
}
