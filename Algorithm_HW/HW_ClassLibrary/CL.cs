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
    }
}
