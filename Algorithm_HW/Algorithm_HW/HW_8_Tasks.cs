using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW_8_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Сортировка подсчетом(WIP)");
            Console.WriteLine("2 - Быстрая сортировка(WIP)");
            Console.WriteLine("3 - Сортировка слиянием(WIP)");
            Console.WriteLine("4 - Сортировка со списком (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_8_Tasks.Task1();
                    break;
                case 2:
                    HW_8_Tasks.Task2();
                    break;
                case 3:
                    HW_8_Tasks.Task3();
                    break;
                case 4:
                    HW_8_Tasks.Task4();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 8.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Сортировка подсчетом");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 8.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Быстрая сортировка");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 8.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Сортировка слиянием");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 8.4
        /// <summary>
        /// Задание 4
        /// </summary>
        private static void Task4()
        {
            CL.BeginApp("Сортировка со списком");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
