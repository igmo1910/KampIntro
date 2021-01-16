using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var number1 = 10;
            var number2 = 30;
            number1 = number2;
            number2 = 65;
        }
    }
}
