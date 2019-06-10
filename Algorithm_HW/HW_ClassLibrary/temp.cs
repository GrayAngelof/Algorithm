//using System;
//using System.Collections.Generic;

//public class dfs
//{
//    Dictionary<int, bool> marks;
//    Stack<int> path; //<-- это стек
//    Graph source; //<-- это моя реализация графа, что там внутри - не важно

//    public void FindPath(Graph gr, int start) //gr - граф, start - номер вершины, от которой нужно найти пути до остальных
//    {
//        marks = new Dictionary<int, bool>();
//        path = new Stack<int>();
//        source = gr;
//        foreach (int i in gr.Keys)
//            marks.Add(i, false);

//        this.DFS(start);
//    }
//    //функция поиска
//    public void DFS(int v)
//    {
//        marks[v] = true;
//        path.Push(v); // сохраняем в стек текущую вершину
//        foreach (int i in path) // выводим путь до текущей
//            Console.Write(i.ToString() + "  ");
//        Console.WriteLine();

//        foreach (int i in source[v].NodeLinks)
//            if (marks[i] == false)
//            {
//                DFS(i);
//                path.Pop(); // не забываем извлекать уже проверенные вершины
//            }
//    }