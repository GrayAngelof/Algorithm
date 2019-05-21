using System;
using HW_ClassLibrary;

namespace Algorithm_HW
{
    class HW_2_Tasks
    {
        #region HW 1
        /// <summary>
        /// Задание 1
        /// </summary>
        public static void Task1()
        {
            CL.BeginApp("Функция перевода из десятичной системы в двоичную");
            Console.WriteLine("Ведите десятичное число:");
            int intNum = Utils.IsInt();
            HW2Libr.DecToBin(intNum);
            CL.ConsolePause();
        }
        #endregion

        #region HW 2
        /// <summary>
        /// Задание 2
        /// </summary>
        public static void Task2()
        {
            CL.BeginApp("Функция возведения числа a в степень b");


            Console.WriteLine("Ведите число:");
            int intNum = Utils.IsInt();
            Console.WriteLine("Ведите Степень:");
            int intPow = Utils.IsInt();
            Console.WriteLine("Возведение без рекурсии:");
            Console.WriteLine(MathLibr.Pow(intNum, intPow));
            Console.WriteLine("Возведение рекурсивно:");
            Console.WriteLine(MathLibr.RecPow(intNum, intPow));

            CL.ConsolePause();
        }
        #endregion

        #region HW 3
        /// <summary>
        /// Задание 3
        /// </summary>
        public static void Task3()
        {
            CL.BeginApp("Калькулятор");

            CL.ConsolePause();
        }
        #endregion
    }
}
