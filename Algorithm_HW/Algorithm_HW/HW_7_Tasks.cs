﻿using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW_7_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Считывать матрицу смежности из файла");
            Console.WriteLine("2 - Рекурсивная функция обхода графа в глубину");
            Console.WriteLine("3 - Функция обхода графа в ширину");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_7_Tasks.Task1();
                    break;
                case 2:
                    HW_7_Tasks.Task2();
                    break;
                case 3:
                    HW_7_Tasks.Task3();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 7.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Считывать матрицу смежности из файла");

            string filename = @"..\..\..\TxtFiles\matrix.txt";
            int[,] matrix = ReadMatrix.Read(filename);

            CL.PrintArr(matrix);
            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 7.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Рекурсивная функция обхода графа в глубину");

            string filename = @"..\..\..\TxtFiles\WorkMatrix.txt";
            int[,] matrix = ReadMatrix.Read(filename);
            CL.PrintArr(matrix);
            SearchGraph search = new SearchGraph();
            search.DFS(matrix);
            //SearchGraph.DFS(matrix);
            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 7.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Функция обхода графа в ширину");

            string filename = @"..\..\..\TxtFiles\WorkMatrix.txt";
            int[,] matrix = ReadMatrix.Read(filename);
            CL.PrintArr(matrix);
            SearchGraph search = new SearchGraph();
            search.BFS(matrix);
            //SearchGraph.BFS(matrix);
            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
