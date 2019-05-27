using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public static class PascalTriangle
    {
        public static int[,] Build(int row, int col)
        {
            int[,] way = new int[row, col];

            for (int j = 0; j < col; j++)
            {
                way[0, j] = 1;
            }

            for (int i = 1; i < row; i++)
            {
                way[i, 0] = 1;
                for (int j = 1; j < col; j++)
                {
                    way[i, j] = way[i, j - 1] + way[i - 1, j];

                }
            }
            return way;
        }

        public static int[,] Build(int row, int col,int[,] map)
        {
            int[,] way = new int[row, col];

            for (int j = 0; j < col; j++)
            {
                way[0, j] = 1;
            }

            for (int i = 1; i < row; i++)
            {
                way[i, 0] = 1;
                for (int j = 1; j < col; j++)
                {
                    if (map[i,j]==0)
                    {
                        way[i, j] = way[i, j - 1] + way[i - 1, j];
                    }
                }
            }
            return way;
        }
    }
}
