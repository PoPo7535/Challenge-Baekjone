using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone1697
    {
        static int[] length = new int[100001];
        static Queue<int> que = new Queue<int>();
        static int N;
        static int K;

        static int BFS()
        {
            int count = -1;

            while (true)
            {
                count++;
                int size = que.Count;

                for (int i = 0; i < size; i++)
                {
                    int current = que.Dequeue();

                    if (current == K)
                        return count;

                    if (current - 1 >= 0 && length[current - 1] == 0)
                    {
                        que.Enqueue(current - 1);
                        length[current - 1] = 1;
                    }

                    if (current + 1 <= 100000 && length[current + 1] == 0)
                    {
                        que.Enqueue(current + 1);
                        length[current + 1] = 1;
                    }

                    if (K > current && current * 2 <= 100000 && length[current * 2] == 0)
                    {
                        que.Enqueue(current * 2);
                        length[current * 2] = 1;
                    }
                }
            }
        }

        static void Problem()
        {
            string[] input = Console.ReadLine().Split();
            N = int.Parse(input[0]);
            K = int.Parse(input[1]);

            que.Enqueue(N);
            length[N] = 1; // 시작 위치 방문 표시

            Console.WriteLine(BFS());
        }
    }
}