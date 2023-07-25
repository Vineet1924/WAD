using System;

namespace LAB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.Write("Enter Value of Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value of Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operation : ");
            Char opr = Convert.ToChar(Console.ReadLine());

            Calculator calculator = new Calculator();
            Console.WriteLine("Answer = " + calculator.Calculate(num1, num2, opr));
        }
    }
}
