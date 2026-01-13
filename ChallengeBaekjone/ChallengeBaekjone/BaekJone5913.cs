using System;

namespace ChallengeBaekjone
{
    public class BaekJone5913
    {
        public void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var map = new bool[5, 5];
            var maxMove = 11 - N / 2;
            var dir = new (int x, int y)[]
            {
                (1, 0), (-1, 0),
                (0, 1), (0, -1)
            };
            var result = 0;
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ');
                int by = int.Parse(input[0]) - 1;
                int bx = int.Parse(input[1]) - 1;
                map[by, bx] = true;
            }
            DFS(0, 0, 4, 4, 0);
            Console.WriteLine(result);
            void DFS(int aX, int aY, int bX, int bY, int deep)
            {
                if (deep == maxMove)
                {
                    var aCheck = false;
                    var bCheck = false;
                    foreach (var pos in dir)
                    {
                        if (CanMove(pos.x + aX, pos.y + aY))
                            aCheck = true;
                        if (CanMove(pos.x + bX, pos.y + bY))
                            bCheck = true;
                    }
                    if (aCheck && bCheck)
                        ++result;
                }
                else
                {
                    foreach (var pos in dir)
                    {
                        var ax = pos.x + aX;
                        var ay = pos.y + aY;
                        if (CanMove(ax, ay))
                        {
                            foreach (var pos2 in dir)
                            {
                                var bx = pos2.x + bX;
                                var by = pos2.y + bY;
                                map[ay, ax] = true;
                                if (CanMove(bx, by))
                                {
                                    map[ay, ax] = true;
                                    map[by, bx] = true;
                                    DFS(ax, ay, bx, by, deep + 1);
                                    map[ay, ax] = false;
                                    map[by, bx] = false;
                                }
                                map[ay, ax] = false;
                            }
                        }
                    }
                }
            }
            bool CanMove(int x, int y)
            {
                if (x == -1 || x == 5 || y == -1 || y == 5)
                    return false;
                if ((x == 0 && y == 0) ||
                    (x == 4 && y == 4))
                    return false;
                if (false == map[y, x])
                    return true;
                return false;
            }
        }
    }
}