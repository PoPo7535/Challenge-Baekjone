using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone24479
    {
        public void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var input = sr.ReadLine().Split(' ');
            var N = int.Parse(input[0]); // 정점
            var M = int.Parse(input[1]); // 간선
            var R = int.Parse(input[2]); // 시작정점
            var visitNum = new int[N + 1];
            var dic = new Dictionary<int, List<int>>();
            for (int i = 1; i <= N; i++)
                dic.Add(i, new List<int>());
            visitNum[0] = 1;
            for (int i = 0; i < M; i++)
            {
                input = sr.ReadLine().Split(' ');
                var start = int.Parse(input[0]);
                var end = int.Parse(input[1]);
                if (false == dic[start].Contains(end))
                    dic[start].Add(end);
                if (false == dic[end].Contains(start))
                    dic[end].Add(start);
            }

            foreach (var list in dic.Values)
                list.Sort();

            visitNum[R] = 1;
            int count = 1;
            DFS(R);
            for (int i = 1; i <= N; i++)
                sw.WriteLine(visitNum[i]);
            sr.Close();
            sw.Close();

            void DFS(int start)
            {
                foreach (var next in dic[start])
                {
                    if (visitNum[next] == 0)
                    {
                        count++;
                        visitNum[next] = count;
                        DFS(next);
                    }
                }
            }
        }
    }
}