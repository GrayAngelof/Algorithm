﻿namespace HW_ClassLibrary
{
    public class Sort
    {
        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Отсортированый массив</returns>
        public static void BubbleSort(int[] array)
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
        }

        /// <summary>
        /// Улучшеная сортировка пузырьком
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Отсортированый массив</returns>
        public static void AdvBubbleSort(int[] array)
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
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Отсортированый массив</returns>
        public static void CoctailSort(int[] array)
        {
            int count = 0;
            int border = 0;
            int leftBorder = 0;
            int rightBorder = array.Length - 1;
            while (leftBorder < rightBorder)
            {
                count++;
                for (int i = leftBorder; i < rightBorder; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        border = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = border;
                        border = i;
                    }
                }

                rightBorder = border;
                if (leftBorder >= rightBorder) break;
                for (int i = rightBorder; i > leftBorder; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        border = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = border;
                        border = i;
                    }
                }
                leftBorder = border;
            }
            System.Console.WriteLine($"Количество итерраций:{count}");
        }

        /// <summary>
        /// Сортировка подсчетом
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="val">Максимальное значение элемента массива</param>
        public static void CountingSort(int[] array, int val)
        {
            int[] frequencyArray= new int[val];

            for (int i = 0; i < array.Length; i++)
            {
                frequencyArray[array[i]]++;
            }

            int count = 0;
            for (int j = 0; j < val; j++)
            {
                for (int i = 0; i < frequencyArray[j]; i++)
                {
                    array[count++] = j;
                }
            }
        }

        public static void quickSort(int[] array)
        {

        }

        int partition(int[] array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }



    }
}
