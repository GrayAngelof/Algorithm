using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class Utils
    {
        /// <summary>
        /// Проверка строки на Int
        /// </summary>
        /// <param name="Str">Проверяемая строка</param>
        /// <returns>Возвращает Int</returns>
        public static int IsInt()
        {
            int intNum;
            string strNum;
            bool isNum;
            do
            {
                strNum = Console.ReadLine();
                isNum = int.TryParse(strNum, out intNum);
            } while (!isNum);
            return intNum;
        }
    }
}
