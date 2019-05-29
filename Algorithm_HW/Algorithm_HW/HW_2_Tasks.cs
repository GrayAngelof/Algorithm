using System;
using HW_ClassLibrary;

namespace Algorithm_HW
{
    internal class HW_2_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Функция перевода из десятичной системы в двоичную");
            Console.WriteLine("2 - Функция возведения числа a в степень b");
            Console.WriteLine("3 - Калькулятор (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_2_Tasks.Task1();
                    break;
                case 2:
                    HW_2_Tasks.Task2();
                    break;
                case 3:
                    HW_2_Tasks.Task3();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 2.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Функция перевода из десятичной системы в двоичную");
            Console.WriteLine("Ведите десятичное число:");
            int intNum = Utils.IsInt();
            HWLibr.DecToBin(intNum);
            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 2.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
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
            Menu();
        }
        #endregion

        #region HW 2.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Калькулятор");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
