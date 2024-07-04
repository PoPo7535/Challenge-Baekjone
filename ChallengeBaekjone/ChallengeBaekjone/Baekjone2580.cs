using System;

namespace ChallengeBaekjone
{
    public class Baekjone2580
    {
        private static readonly int SIZE = 9;

        public static void Problem()
        {
            int[,] board = new int[SIZE, SIZE];
    
            for (int i = 0; i < SIZE; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < SIZE; j++)
                {
                    board[i, j] = int.Parse(line[j]);
                }
            }
    
            if (SolveSudoku(board))
                PrintBoard(board);
            else
                Console.WriteLine("No solution exists.");
        }
    
        private static bool SolveSudoku(int[,] board)
        {
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int num = 1; num <= SIZE; num++)
                        {
                            if (IsSafe(board, row, col, num))
                            {
                                board[row, col] = num;
    
                                if (SolveSudoku(board))
                                    return true;
                                
                                board[row, col] = 0; 
                            }
                        }
                        return false; 
                    }
                }
            }
            return true;
        }
    
        private static bool IsSafe(int[,] board, int row, int col, int num)
        {
            for (int x = 0; x < SIZE; x++)
            {
                if (board[row, x] == num)
                    return false;
            }
    
            for (int x = 0; x < SIZE; x++)
            {
                if (board[x, col] == num)
                    return false;
            }
    
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (board[i + startRow, j + startCol] == num)
                        return false;
            }
    
            return true;
        }
    
        private static void PrintBoard(int[,] board)
        {
            for (int r = 0; r < SIZE; r++)
            {
                for (int d = 0; d < SIZE; d++)
                {
                    Console.Write(board[r, d]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}