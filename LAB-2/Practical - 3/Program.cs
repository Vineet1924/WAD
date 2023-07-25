using System;
using Calculator;

namespace Driver
{
    class Application
    {
        static void Main(String[] args)
        {
            int a = 10;
            int b = 20;

            int sum = Sum.Addition(a, b);
            Console.WriteLine(sum);

            int sub = Sub.Subtraction(a, b);
            Console.WriteLine(sub);
        }
    }
}