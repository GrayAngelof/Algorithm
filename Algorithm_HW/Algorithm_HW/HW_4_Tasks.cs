using HW_ClassLibrary;
using System;
using System.Data;

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

            Random rand = new Random();
            int row = 8;
            int col = 8;
            int[,] map = new int[row, col];

            for (int i = 0; i < (row * col) / 10; i++)
            {
                int index0 = rand.Next(row);
                int index1 = rand.Next(col);
                map[index0, index1] = 1;
            }
            CL.PrintArr(map);

            int[,] way = PascalTriangle.Build(8, 8, map);
            //int[,] way = PascalTriangle.Build(8, 8);
            CL.PrintArr(way);

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
