using System;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone1018
    {
        public static void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            var Y = int.Parse(input[0]);
            var X = int.Parse(input[1]);
            var board = new char[X, Y];
            var result = int.MaxValue;
            
            for (var y = 0; y < Y; ++y)
            {
                var str = Console.ReadLine();
                for (var x = 0; x < X; ++x)
                {
                    board[x, y] = str[x];
                }
            }

            for (var y = 0; y < Y; ++y)
            {
                if (Y < y + 8)
                    break;
                
                for (var x = 0; x < X; ++x)
                {
                    if (X < x + 8)
                        break;

                    var cur = board[x, y];
                    var cur2 = board[x, y] == 'W' ? 'B' : 'W';
                    var num = 0;
                    var num2 = 0;
                    for (var i = 0; i < 8; ++i)
                    {
                        for (var j = 0; j < 8; ++j)
                        {
                            if (cur != board[x + j, y + i])
                                ++num;
                            if (cur2 != board[x + j, y + i])
                                ++num2;
                            if (j != 7)
                                cur = cur == 'W' ? 'B' : 'W';
                            if (j != 7)
                                cur2 = cur2 == 'W' ? 'B' : 'W';
                        }
                    }
                    if (num < result) result = num;
                    if (num2 < result) result = num2;
                }
            }
            Console.WriteLine(result);
        }
    }
}