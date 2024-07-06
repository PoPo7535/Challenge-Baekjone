using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone14889
    {
        static int[,] table;
        static int N;
        static int startScore = 0;
        static int linkScore = 0;
        private static int minVal = int.MaxValue;
        static void Problem()
        {
            N = int.Parse(Console.ReadLine());
            table = new int[N, N];
            for (int i = 0; i < N; ++i)
            {
                var inputs = Console.ReadLine().Split();
                for (int j = 0; j < N; ++j)
                    table[i, j] = int.Parse(inputs[j]);
            }
            var numbers = Enumerable.Range(1, N).ToArray();
            GetCombinations(numbers, new int[N / 2], 0, 0);
            Console.WriteLine(minVal);
        }

        // 조합 생성 메서드
        static void GetCombinations(int[] numbers, int[] curCombin, int currentIndex, int start)
        {
            if (currentIndex == curCombin.Length)
            {
                var hashSet = Enumerable.Range(1, N).ToHashSet();
                foreach (var t in curCombin)
                    hashSet.Remove(t);
                var arr = hashSet.ToArray();
                var teamScore1 = 0;
                var teamScore2 = 0;
                for (int i = 0; i < curCombin.Length; ++i)
                {
                    for (int j = 0; j < curCombin.Length; ++j)
                    {
                        teamScore1 += table[curCombin[i] - 1, curCombin[j] - 1];
                        teamScore2 += table[arr[i] - 1, arr[j] - 1];
                    }
                }

                var score = Math.Abs(teamScore1 - teamScore2);
                if (score < minVal)
                    minVal = score;
                return;
            }

            for (int i = start; i < numbers.Length; i++)
            {
                curCombin[currentIndex] = numbers[i];
                GetCombinations(numbers, curCombin, currentIndex + 1, i + 1);
            }
        }
    }
}