using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HW_ClassLibrary
{
    public class SearchGraph
    {
        /// <summary>
        /// Массив отмечающий посещённые вершины
        /// </summary>
        private bool[] used;
        /// <summary>
        /// Размер матрицы
        /// </summary>
        private int size;
        /// <summary>
        /// Стэк, хранящий номера вершин
        /// </summary>
        private Stack<int> path;
        /// <summary>
        /// Очередь, хранящая номера вершин
        /// </summary>
        private Queue<int> q;
        /// <summary>
        /// Матрица смежности для DFS
        /// </summary>
        private int[,] source;
        private Random rand = new Random();

        #region BFS
        public void BFS(int[,] matrix)
        {
            q = new Queue<int>();
            size = matrix.GetLength(0);
            int randomVertex = rand.Next(0, size);
            used = new bool[size];
            for (int i = 0; i < size; i++)
            {
                used[i] = false;
            }
            used[randomVertex] = true;

            q.Enqueue(randomVertex);
            Console.WriteLine("Начинаем обход с {0} узла", randomVertex + 1);
            while (q.Count != 0)
            {
                randomVertex = q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", randomVertex + 1);
                Console.WriteLine("Ищем непосещенные узлы");
                for (int i = 0; i < size; i++)
                {
                    if (matrix[randomVertex,i]==1)
                    {
                       
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Нашли узел {0}, добавили в очередь", i + 1);
                        }
                    }
                }
                Console.WriteLine("Других не посещенных узлов не найдено");
            }
        }

        #endregion

        #region DFS

        public void DFS(int[,] matrix)
        {
            source = matrix;
            size = matrix.GetLength(0);
            used = new bool[size];
            path= new Stack<int>();
            int randomVertex = rand.Next(0, size);

            for (int i = 0; i < size; i++)
            {
                used[i] = false;
            }

            DFSRec(randomVertex);
        }

        private void DFSRec(int vertex)
        {
            used[vertex] = true;
            path.Push(vertex);
            Console.WriteLine("Начинаем обход {0} узла", vertex + 1);

            for (int i = 0; i < size; i++)
            {
                if (source[vertex, i] == 1)
                {
                    if (!used[i])
                    {
                        Console.WriteLine("Нашли узел {0}, добавили в стек", i + 1);
                        DFSRec(i);
                        Console.WriteLine("Прошли узел {0}, убрали из стека", i + 1);
                        path.Pop();
                    }
                }
            }
        }
        #endregion
    }
}
