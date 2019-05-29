namespace HW_ClassLibrary
{
    public class Search
    {
        /// <summary>
        /// Бинарный поиск
        /// </summary>
        /// <param name="array">Осортированый массив</param>
        /// <param name="num">Искомое число</param>
        /// <returns>Возвращает индекс искомого числа или -1, если число не найдено</returns>
        public static int BinarySearch(int[] array, int num)
        {
            int leftBorder = 0;
            int rightBorder = array.Length;
            int middle=0;
            int index;

            if (num < array[0])
            {
                return index = -1;
            }

            while (rightBorder - leftBorder > 1)
            {
                middle = (rightBorder + leftBorder) / 2;
                if (num < array[middle])
                {
                    rightBorder = middle;
                }
                else 
                {
                    leftBorder = middle;
                }
            }

            if (num == array[leftBorder])
            {
                return index = leftBorder;
            }
            else
            {
                return index = -1;
            }
        }
    }
}
