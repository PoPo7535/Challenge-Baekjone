using System;

namespace ChallengeBaekjone
{
    public class Baekjone9663
    {
        public static void Problem()
        {
            N = int.Parse(Console.ReadLine());
            chessBoard = new int[N, N];
            NQueen(0,0);
            Console.WriteLine(count);
        }
        private static int N;
        private static int useQueen;
        private static int[,] chessBoard;
        private static int count = 0;
        private static void NQueen(int startX, int startY)
        {
            for (var x = startX; x < N; ++x)
            {
                for (var y = startY; y < N; ++y)
                {
                    if (0 == chessBoard[x, y])
                    {
                        Cal(true, x, y);
                        ++useQueen;
                        if (useQueen == N)
                            ++count;
                        NQueen(x, y);
                        Cal(false, x, y);
                 
                        --useQueen;
                    }
                }
            }
        }
        private static void Print(int x, int y)
        {
            Console.WriteLine($"{x} {y}------------------------------------");
            for (int xPos = 0; xPos < N; ++xPos)
            {
                for (int yPos = 0; yPos < N; ++yPos)
                {
                    Console.Write(chessBoard[xPos, yPos]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"------------------------------------------");
        }
        private static void Cal(bool isPush, int x, int y)
        {
            var num = isPush ? 1 : -1;
            ++chessBoard[x, y];
            for (int i = 0; i < N; ++i)
            {
                if (i != x)
                    chessBoard[x, i] += num;
                if (i != y)
                    chessBoard[i, y] += num;
        
                Print(x, y);
            }
            return;
            var xy = Math.Abs(x - y);
            if (y < x)
            {
                for (int i = 0; i + x < N; ++i)
                {
                    chessBoard[xy, i] += num;
                    chessBoard[xy, N - 1 - i] += num;
                }
            }
            else
            {
                for (int i = 0; i + y < N; ++i)
                {
                    chessBoard[i, xy] += num;
                    chessBoard[N - 1 - i, xy] += num;
                }
            }
        }
    }
}