namespace HW_ClassLibrary
{
    public static class PascalTriangle
    {
        public static int[,] Build(int row, int col)
        {
            int[,] way = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        way[i, j] = 1;
                    }
                    else
                    {
                        way[i, j] = way[i, j - 1] + way[i - 1, j];
                    }
                }
            }
            return way;
        }

        public static int[,] Build(int row, int col, int[,] map)
        {
            int[,] way = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (map[i, j] == 0)
                    {
                        if (i == 0)
                        {
                            if (j != 0)
                            {
                                if (way[i, j - 1] == 1)
                                {
                                    way[i, j] = 1;
                                }
                            }
                            else
                            {
                                way[i, j] = 1;
                            }
                        }
                        else if (j == 0)
                        {
                            if (i != 0)
                            {
                                if (way[i - 1, j] == 1)
                                {
                                    way[i, j] = 1;
                                }
                            }
                            else
                            {
                                way[i, j] = 1;
                            }
                        }
                        else
                        {
                            if (map[i, j] == 0)
                            {
                                way[i, j] = way[i, j - 1] + way[i - 1, j];
                            }
                        }
                    }
                }
            }
            return way;
        }
    }
}
