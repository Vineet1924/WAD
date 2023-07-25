using System;

namespace Lab_1_EX_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(number + " is not Prime Number");
                    return;
                }
            }
            Console.WriteLine(number + " is Prime Number");
        }
    }
}
