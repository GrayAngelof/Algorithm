using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class CL
    {
        /// <summary>
        /// Очистка окна консоли и вывод приглашение в приложение
        /// </summary>
        /// <param name="message">Строка с описанием приложения</param>
        public static void BeginApp(string message)
        {
            Console.Clear();
            Console.WriteLine($"Добро пожаловать в приложение \"{message}\"");
        }

        /// <summary>
        /// Задержка закрытия консоли
        /// </summary>
        public static void ConsolePause()
        {
            Console.WriteLine();
            Console.WriteLine("нажмите любую клавишу");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод на экран одномерного массива
        /// </summary>
        /// <param name="array">Заданый массив</param>
        public static void PrintArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод на экран двумерного массива
        /// </summary>
        /// <param name="array">Заданый массив</param>
        public static void PrintArr(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод на экран двумерного лабиринта
        /// </summary>
        /// <param name="array">Заданый массив</param>
        public static void PrintArr(int[,] array, bool flag)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //Console.Write(array[i, j]);
                    if (Convert.ToString(array[i, j]) == "1")
                    {
                        //Console.Write((char)65);
                        Console.Write(Encoding.GetEncoding(1251).GetString(new byte[] { 2 })[0]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}