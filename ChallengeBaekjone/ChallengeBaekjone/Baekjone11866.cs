using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone11866
    {
        public static void Problem()
        {
            LinkedList<int> list = new LinkedList<int>();
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var M = int.Parse(input[1]);
            for (int i = 1; i <= N; ++i)
                list.AddLast(i);
            Console.Write('<');
            var node = list.First;
            while (0 != list.Count)
            {
                for (int i = 0; i < M-1; ++i)
                {
                    node = node.Next ?? list.First;
                }
                var bumpNode = node.Next ?? list.First;
                Console.Write(node.Value);
                list.Remove(node);
                if(list.Count != 0)
                    Console.Write(", ");
                node= bumpNode;
            }
            Console.Write('>');
        }
    }
}