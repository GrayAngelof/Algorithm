using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW_6_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Реализовать простейшую хеш-функцию (WIP)");
            Console.WriteLine("2 - Переписать программу, реализующую двоичное дерево поиска (WIP)");
            Console.WriteLine("3 - Разработать базу данных студентов (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_6_Tasks.Task1();
                    break;
                case 2:
                    HW_6_Tasks.Task2();
                    break;
                case 3:
                    HW_6_Tasks.Task3();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 6.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Реализовать простейшую хеш-функцию");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 6.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Переписать программу, реализующую двоичное дерево поиска");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 6.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Разработать базу данных студентов");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
