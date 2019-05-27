using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassLibrary
{
    public class Horse
    {
        private static int row = 8;
        private static int col = 8;
        public static int[,] board = new int[row, col];

        static int[] moveX = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] moveY = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int t = 2;
        static int x = 0;
        static int y = 0;
        static int k = 0;

        public static void SearchSolution()
        {
            Zero();
            board[0, 0] = 1;
            
            Move(k);
        }

        private static void Move(int step)
        {
            int nx = x;
            int ny = y;
            int tx = x;
            int ty = y;

            for (int dir = 0; dir < 8; dir++)
            {
                nx = tx + moveX[dir];
                ny = ty + moveY[dir];
                if (nx < 0 || nx >= row || ny < 0 || ny >= col)
                {
                    nx = tx; ny = ty;
                    continue;
                }
                if (board[nx,ny] > 0)
                    continue;
                x = nx; y = ny;
                board[x,y] = t;
                t++;
                Move(k + 1);
            }
        }

        private static void Zero()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
    }
}
