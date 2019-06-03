using HW_ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm_HW
{
    internal class HW_5_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Перевод из десятичной в двоичную систему счисления с использованием стека");
            Console.WriteLine("2 - Проверка на выделение памяти (WIP)");
            Console.WriteLine("3 - Скобочная последовательность");
            Console.WriteLine("4 - Копирование односвязного списка (WIP)");
            Console.WriteLine("5 - Перевод из инфиксной записи арифметического выражения в постфиксную");
            Console.WriteLine("6 - Реализовать очередь (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_5_Tasks.Task1();
                    break;
                case 2:
                    HW_5_Tasks.Task2();
                    break;
                case 3:
                    HW_5_Tasks.Task3();
                    break;
                case 4:
                    HW_5_Tasks.Task4();
                    break;
                case 5:
                    HW_5_Tasks.Task5();
                    break;
                case 6:
                    HW_5_Tasks.Task6();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 5.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Перевод из десятичной в двоичную систему счисления с использованием стека");

            Console.WriteLine("Ведите десятичное число:");
            int intNum = Utils.IsInt();
            HWLibr.DecToBinStack(intNum);
            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 5.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Проверка на выделение памяти");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 5.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Скобочная последовательность");
            Console.WriteLine("Ведите cкобочную последовательность () {} []:");
            var s = Console.ReadLine();
            var checker = new BracketsChecker();

            foreach (var ch in s)
                checker.Put(ch);

            Console.WriteLine(checker.Balanced);

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 5.4
        /// <summary>
        /// Задание 4
        /// </summary>
        private static void Task4()
        {
            CL.BeginApp("Копирование односвязного списка");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 5.5
        /// <summary>
        /// Задание 5
        /// </summary>
        private static void Task5()
        {
            CL.BeginApp("Перевод из инфиксной записи арифметического выражения в постфиксную");
            Queue<string> ansfer = new Queue<string>();

            Console.WriteLine("выражение:");
            string input = Console.ReadLine();
            ansfer = RPN.TranferToRPN(input);
            foreach (string s in ansfer)
            {
                Console.Write(s+" ");
            }
            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 5.6
        /// <summary>
        /// Задание 6
        /// </summary>
        private static void Task6()
        {
            CL.BeginApp("Реализовать очередь");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
