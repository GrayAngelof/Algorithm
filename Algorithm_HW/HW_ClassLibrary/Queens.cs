using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class Queens
    {
        private static int row = 8;
        private static int col= 8;
        public static int[,] board =new int[row,col];
        public static bool SearchSolution(int n)
        {
            if (!CheckBoard())
            {
                return false;
            }

            if (n == 9)
            {
                return true;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i,j]==0)
                    {
                        board[i, j] = n;
                        if (SearchSolution(n+1))
                        {
                            return true;
                        }
                        board[i, j] = 0;
                    }
                }
            }
            return false;
        }

        public static void Zero()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        private static bool CheckBoard()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] != 0)
                    {
                        if (!CheckQueen(i, j))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private static bool CheckQueen(int x, int y)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i,j]!=0)
                    {
                        if (!(i==x && j==y))
                        {
                            if (i-x==0 || j-y == 0)
                            {
                                return false;
                            }

                            if (Math.Abs(i-x)== Math.Abs(j-y))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
