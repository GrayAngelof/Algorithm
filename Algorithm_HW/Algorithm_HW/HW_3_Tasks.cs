using HW_ClassLibrary;

namespace Algorithm_HW
{
    class HW_3_Tasks
    {
        #region HW 1
        /// <summary>
        /// Задание 1
        /// </summary>
        public static void Task1()
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
        }
        #endregion

        #region HW 2
        /// <summary>
        /// Задание 2
        /// </summary>
        public static void Task2()
        {
            CL.BeginApp(" ");

            CL.ConsolePause();
        }
        #endregion

        #region HW 3
        /// <summary>
        /// Задание 3
        /// </summary>
        public static void Task3()
        {
            CL.BeginApp(" ");

            CL.ConsolePause();
        }
        #endregion

        #region HW 4
        /// <summary>
        /// Задание 4
        /// </summary>
        public static void Task4()
        {
            CL.BeginApp(" ");

            CL.ConsolePause();
        }
        #endregion
    }
}
