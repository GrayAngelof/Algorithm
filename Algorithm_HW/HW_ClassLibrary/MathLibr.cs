using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class MathLibr
    {
        public static int RecPow(int num, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow > 0)
                return RecPow(num, pow - 1) * num;
            return 1 / RecPow(num, -pow);
        }

        public static int Pow(int num, int pow)
        {
            int x = 1;
            while (pow > 0)
            {
                x *= num;
                pow--;
            }
            return x;
        }
    }
}
