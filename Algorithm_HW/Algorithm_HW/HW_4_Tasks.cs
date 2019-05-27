using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW_4_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Количество маршрутов с препятствиями");
            Console.WriteLine("2 - Длина максимальной последовательности (WIP)");
            Console.WriteLine("3 - Обойти конем шахматную доску (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_4_Tasks.Task1();
                    break;
                case 2:
                    HW_4_Tasks.Task2();
                    break;
                case 3:
                    HW_4_Tasks.Task3();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 4.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Количество маршрутов с препятствиями");
            System.Console.WriteLine("Количество строк лабиринта:");
            int rowsMaze = Utils.IsInt();
            System.Console.WriteLine("Количество столбцов лабиринта:");
            int colMaze = Utils.IsInt();
            int[,] maze = MazeGenerator.FromDimensions(rowsMaze, colMaze);
            CL.PrintArr(maze,true);


            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 4.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Длина максимальной последовательности");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 4.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Обойти конем шахматную доску");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
