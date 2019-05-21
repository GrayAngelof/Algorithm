using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class HW2Libr
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
    }
}
