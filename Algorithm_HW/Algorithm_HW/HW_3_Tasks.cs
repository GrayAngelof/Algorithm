using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW_3_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Пузырьковая сортировка");
            Console.WriteLine("2 - Шейкерная сортировка");
            Console.WriteLine("3 - Бинарный алгоритм поиска");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_3_Tasks.Task1();
                    break;
                case 2:
                    HW_3_Tasks.Task2();
                    break;
                case 3:
                    HW_3_Tasks.Task3();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 3.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Пузырьковая сортировка");
            System.Console.WriteLine("Количество элементов массива:");
            int amount = Utils.IsInt();
            int[] array = new int[amount];
            int[] bublArray = new int[amount];
            int[] advBublArray = new int[amount];
            Utils.RandArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                bublArray[i] = array[i];
                advBublArray[i] = array[i];
            }
            //CL.PrintArr(array);

            System.Console.WriteLine("Сортировка пузырьком");
            Sort.BubbleSort(bublArray);
            //CL.PrintArr(bublArray);
            System.Console.WriteLine("Сортировка улучшеным пузырьком");
            Sort.AdvBubbleSort(advBublArray);
            //CL.PrintArr(advBublArray);

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 3.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Шейкерная сортировка");
            System.Console.WriteLine("Количество элементов массива:");
            int amount = Utils.IsInt();
            int[] array = new int[amount];
            Utils.RandArray(array);
            Sort.CoctailSort(array);
            //CL.PrintArr(array);

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 3.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Бинарный алгоритм поиска");
            System.Console.WriteLine("Количество элементов массива(массив будет заполняться от 0 до N*2):");
            int amount = Utils.IsInt();
            int[] array = new int[amount];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i+1)*2;
            }
            CL.PrintArr(array);

            System.Console.WriteLine("Искомое значение:");
            int num = Utils.IsInt();
            Console.WriteLine("Индекс :");
            Console.WriteLine(Search.BinarySearch(array, num));

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
