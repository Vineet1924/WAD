using System;

namespace Lab_1_EX_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string str = Console.ReadLine();
            String rev = "";
            int n = str.Length;
            Console.WriteLine(n);
            for(int i = n - 1; i >= 0; i--)
            {
                rev += str[i].ToString();
            }

            if(rev == str)
            {
                Console.WriteLine(str + " is Palindrome");
            } else
            {
                Console.WriteLine(str + " is not Palindrome");
            }
        }
    }
}
