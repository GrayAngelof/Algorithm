namespace HW_ClassLibrary
{
    public class Sort
    {
        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Отсортированый массив</returns>
        public static int[] BubbleSort(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Utils.Swap(ref array[i], ref array[j]);
                    }
                }
            }
            System.Console.WriteLine($"Количество итерраций:{count}");
            return array;
        }

        /// <summary>
        /// Улучшеная сортировка пузырьком
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Отсортированый массив</returns>
        public static int[] AdvBubbleSort(int[] array)
        {
            bool action = true;
            int count = 0;
            int i = 0;
            while (action)
            {
                count++;
                action = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if ((array[j] > array[j + 1]))
                    {
                        Utils.Swap(ref array[j], ref array[j + 1]);
                        action = true;
                    }
                }
                i++;
            }
            System.Console.WriteLine($"Количество итерраций:{count}");
            return array;
        }
    }
}
