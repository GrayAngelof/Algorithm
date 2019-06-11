using HW_ClassLibrary;
using System;

namespace Algorithm_HW
{
    internal class HW
    {
        internal static void Main()
        {
            Console.Clear();
            Console.WriteLine("Выберите урок:");
            Console.WriteLine("1 - Простые алгоритмы (WIP)");
            Console.WriteLine("2 - Асимптотическая сложность алгоритма. Рекурсия");
            Console.WriteLine("3 - Поиск в массиве. Простые сортировки");
            Console.WriteLine("4 - Динамическое программирование. Поиск возвратом");
            Console.WriteLine("5 - Динамические структуры данных");
            Console.WriteLine("6 - Деревья");
            Console.WriteLine("7 - Графы. Алгоритмы на графах");
            Console.WriteLine("8 - Сложные сортировки (WIP)");
            int choice = Utils.IsInt();

            switch (choice)
            {
                case 1:
                    HW_1_Tasks.Menu();
                    break;
                case 2:
                    HW_2_Tasks.Menu();
                    break;
                case 3:
                    HW_3_Tasks.Menu();
                    break;
                case 4:
                    HW_4_Tasks.Menu();
                    break;
                case 5:
                    HW_5_Tasks.Menu();
                    break;
                case 6:
                    HW_6_Tasks.Menu();
                    break;
                case 7:
                    HW_7_Tasks.Menu();
                    break;
                case 8:
                    HW_8_Tasks.Menu();
                    break;
                default:
                    break;
            }
        }
    }
}
