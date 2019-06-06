using HW_ClassLibrary;
using System;
using System.Runtime.InteropServices;

namespace Algorithm_HW
{
    internal class HW_6_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Реализовать простейшую хеш-функцию");
            Console.WriteLine("2 - Переписать программу, реализующую двоичное дерево поиска");
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
            System.Console.WriteLine("Ведите строку:");
            string s = Console.ReadLine();
            int res = MyHash.Hash(s);
            Console.WriteLine(res);

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

            BinaryTree<int> integerTree = new BinaryTree<int>();
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                int value = rand.Next(100);
                integerTree.Add(value);
            }

            Console.WriteLine("Number of nodes is {0}", integerTree.Count);
            Console.WriteLine("Max value is {0}", integerTree.MaxValue);
            Console.WriteLine("Min value is {0}", integerTree.MinValue);
            Console.WriteLine("Pre-order traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Preorder()));
            Console.WriteLine("In-order traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Inorder()));
            Console.WriteLine("Post-order traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Postorder()));
            Console.WriteLine("Level-order traversal:");
            Console.WriteLine(string.Join(" ", integerTree.Levelorder()));
            Console.WriteLine("Default traversal (inorder):");
            foreach (int n in integerTree)
                Console.Write("{0} ", n);
            Console.WriteLine();

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
