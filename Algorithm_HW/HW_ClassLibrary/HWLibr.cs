using System;
using System.Collections.Generic;

namespace HW_ClassLibrary
{
    public class HWLibr
    {
        public static void DecToBin(int n)
        {
            if (n < 0)
            {
                Console.Write("-");
                DecToBin(-n);
            }
            else if (n < 2)
            {
                Console.Write(n);
                return;
            }
            else
            {
                DecToBin(n / 2);
                int res = n % 2;
                Console.Write(res);
            }
        }

        public static void DecToBinStack(int n)
        {
            var stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n /= 2;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
