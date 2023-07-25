using System;
using Calculator;

namespace Driver
{
    public class Application
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int sum = 0, sub = 0, mul = 0;
            double div = 0;

            sum = Calc.Add(a, b);
            sub = Calc.Sub(a, b);
            mul = Calc.Mul(a, b);
            div = Calc.Div((double)a, (double)b);

            Console.WriteLine("Addition : " + sum);
            Console.WriteLine("Subtraction : " + sub);
            Console.WriteLine("Multiplication : " + mul);
            Console.WriteLine("Division : " + div);
        }
    }
}

