using System;

namespace HW_ClassLibrary
{
    /// <summary>
    /// Генератор лабиринта
    /// </summary>
    public static class MazeGenerator
    {
        static float placementThreshold = .1f;    // chance of empty space

        public static int[,] FromDimensions(int sizeRows, int sizeCols)
        {
            int[,] maze = new int[sizeRows, sizeCols];
            int rMax = maze.GetUpperBound(0);
            int cMax = maze.GetUpperBound(1);
            Random rnd = new Random();

            for (int i = 0; i <= rMax; i++)
            {
                for (int j = 0; j <= cMax; j++)
                {
                    if (i == 0 || j == 0 || i == rMax || j == cMax)
                    {
                        maze[i, j] = 1;
                    }
                    else if (i % 2 == 0 && j % 2 == 0)
                    {
                        if (rnd.NextDouble() > placementThreshold)
                        {
                            maze[i, j] = 1;
                            int a = rnd.NextDouble() < .5 ? 0 : (rnd.NextDouble() < .5 ? -1 : 1);
                            int b = a != 0 ? 0 : (rnd.NextDouble() < .5 ? -1 : 1);
                            maze[i + a, j + b] = 1;
                        }
                    }
                }
            }
            return maze;
        }
    }
}