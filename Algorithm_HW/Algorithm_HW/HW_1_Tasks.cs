using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    class HW_1_Tasks
    {
        #region Menu
        internal static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Рассчёт индекса массы тела (WIP)");
            Console.WriteLine("2 - Найти максимальное из четырех чисел (WIP)");
            Console.WriteLine("3 - Обмен значениями двух переменных (WIP)");
            Console.WriteLine("4 - Нахождение корней заданного квадратного уравнения (WIP)");
            Console.WriteLine("5 - пределитель, к какому времени года относится месяц (WIP)");
            Console.WriteLine("6 - Возраст человека (от 1 до 150 лет) (WIP)");
            Console.WriteLine("7 - Определить, относятся поля к одному цвету или нет (WIP)");
            Console.WriteLine("8 - Квадраты и кубы чисел от a до b (WIP)");
            Console.WriteLine("9 - Найти частное от деления нацело (WIP)");
            Console.WriteLine("10 - Определить, имеются ли в записи числа N нечетные цифры (WIP)");
            Console.WriteLine("11 - Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8 (WIP)");
            Console.WriteLine("12 - Функция нахождения максимального из трех чисел (WIP)");
            Console.WriteLine("13 - Функция, генерирующую случайное число от 1 до 100 (WIP)");
            Console.WriteLine("14 - Автоморфные числа (WIP)");
            Console.WriteLine("0 - Выход в меню выбора уроков");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 0:
                    HW.Main();
                    break;
                case 1:
                    HW_1_Tasks.Task1();
                    break;
                case 2:
                    HW_1_Tasks.Task2();
                    break;
                case 3:
                    HW_1_Tasks.Task3();
                    break;
                case 4:
                    HW_1_Tasks.Task4();
                    break;
                case 5:
                    HW_1_Tasks.Task5();
                    break;
                case 6:
                    HW_1_Tasks.Task6();
                    break;
                case 7:
                    HW_1_Tasks.Task7();
                    break;
                case 8:
                    HW_1_Tasks.Task8();
                    break;
                case 9:
                    HW_1_Tasks.Task9();
                    break;
                case 10:
                    HW_1_Tasks.Task10();
                    break;
                case 11:
                    HW_1_Tasks.Task11();
                    break;
                case 12:
                    HW_1_Tasks.Task12();
                    break;
                case 13:
                    HW_1_Tasks.Task13();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region HW 1.1
        /// <summary>
        /// Задание 1
        /// </summary>
        private static void Task1()
        {
            CL.BeginApp("Рассчёт индекса массы тела");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.2
        /// <summary>
        /// Задание 2
        /// </summary>
        private static void Task2()
        {
            CL.BeginApp("Найти максимальное из четырех чисел");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.3
        /// <summary>
        /// Задание 3
        /// </summary>
        private static void Task3()
        {
            CL.BeginApp("Обмен значениями двух переменных");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.4
        /// <summary>
        /// Задание 4
        /// </summary>
        private static void Task4()
        {
            CL.BeginApp("Нахождение корней заданного квадратного уравнения");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.5
        /// <summary>
        /// Задание 5
        /// </summary>
        private static void Task5()
        {
            CL.BeginApp("Определитель, к какому времени года относится месяц");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.6
        /// <summary>
        /// Задание 6
        /// </summary>
        private static void Task6()
        {
            CL.BeginApp("Возраст человека (от 1 до 150 лет)");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.7
        /// <summary>
        /// Задание 7
        /// </summary>
        private static void Task7()
        {
            CL.BeginApp("Определить, относятся поля к одному цвету или нет");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.8
        /// <summary>
        /// Задание 8
        /// </summary>
        private static void Task8()
        {
            CL.BeginApp("Квадраты и кубы чисел от a до b");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.9
        /// <summary>
        /// Задание 9
        /// </summary>
        private static void Task9()
        {
            CL.BeginApp("Найти частное от деления нацело");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.10
        /// <summary>
        /// Задание 10
        /// </summary>
        private static void Task10()
        {
            CL.BeginApp("Определить, имеются ли в записи числа N нечетные цифры");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.11
        /// <summary>
        /// Задание 11
        /// </summary>
        private static void Task11()
        {
            CL.BeginApp("Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.12
        /// <summary>
        /// Задание 12
        /// </summary>
        private static void Task12()
        {
            CL.BeginApp("Функция нахождения максимального из трех чисел");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.13
        /// <summary>
        /// Задание 13
        /// </summary>
        private static void Task13()
        {
            CL.BeginApp("Функция, генерирующую случайное число от 1 до 100");

            CL.ConsolePause();
            Menu();
        }
        #endregion

        #region HW 1.14
        /// <summary>
        /// Задание 14
        /// </summary>
        private static void Task14()
        {
            CL.BeginApp("Автоморфные числа");

            CL.ConsolePause();
            Menu();
        }
        #endregion
    }
}
