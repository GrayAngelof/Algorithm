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

        /// <summary>
        /// Обмен значений между двумя переменными
        /// </summary>
        /// <param name="var1">Переменная 1</param>
        /// <param name="var2">Переменная 2</param>
        public static void Swap(ref int var1, ref int var2)
        {
            var1 = var1 + var2;
            var2 = var2 - var1;
            var2 = -var2;
            var1 = var1 - var2;
        }

        /// <summary>
        /// Заполнение массива случайными значениями
        /// </summary>
        /// <param name="array">Заполняемый массив</param>
        public static void RandArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);
            }
        }
    }
}
