using System;

namespace LAB_1
{
    internal class Calculator
    {
        public int Calculate(int num1, int num2, char opr)
        {
            int ans = 0;
            switch(opr)
            {
                case '+': ans = num1 + num2; 
                    break;
                case '-':
                    ans = num1 - num2;
                    break;
                case '*':
                    ans = num1 * num2;
                    break;
                case '/':
                    ans = num1 / num2;
                    break;
            }
            return ans;
        }
    }
}