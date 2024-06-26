using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone2346
    {
        public static void Problem()
        {
            var list = new LinkedList<int>();
            var N = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var moves = new int[N];
            for(int i = 0 ; i <N; ++i)
                moves[i] = int.Parse(input[i]);
            for (int i = 1; i <= N; ++i)
                list.AddLast(i);
            var node = list.First;
            for (int i = 0; i < N; ++i)
            {
                var removeNode = node;
                var val = moves[removeNode.Value - 1];
                for (int j = 0; j < Math.Abs(val); ++j)
                {
                    if (list.Count == 0)
                        break;
                    if (val> 0)
                        node = node.Next ?? list.First;
                    else
                        node = node.Previous ?? list.Last;
                    if (j == 0)
                        list.Remove(removeNode);
                }
                Console.Write($"{removeNode.Value}");
                if (list.Count != 0)
                    Console.Write($" ");
            }
        }
    }
}