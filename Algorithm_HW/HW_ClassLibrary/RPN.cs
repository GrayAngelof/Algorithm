using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HW_ClassLibrary
{
    public static class RPN
    {
        public static Queue<string> TranferToRPN(string input)
        {
            Queue<string> output = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char token = input[i];
                if (char.IsNumber(token))
                {
                    string value = input.Substring(i, 1);
                    output.Enqueue(value);
                }
                else if (IsOperator(token))
                {
                    string value = input.Substring(i, 1);
                    stack.Push(value);
                }
            }

            for (int i = 0; i < stack.Count; i++)
            {
                string value = stack.Pop();
                i--;
                output.Enqueue(value);
            }

            return output;
        }

        private static bool IsOperator(char token)
        {
            return token == '-' || token == '+' || token == '/' || token == '*' || token == '^';
        }
    }


}
