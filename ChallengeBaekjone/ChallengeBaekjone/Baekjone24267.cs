using System;

namespace ChallengeBaekjone
{
    public class Baekjone24267
    {

        public static void Problem()
        {
            var n = long.Parse(Console.ReadLine());
            long s = 0;
            for (long i = 1; i <= n - 2; i++) // 추후 long long i = 1 으로 수정
                s += (i * i + i) / 2; // i * i는 int형 범위 내에서만 계산됨. 상수x ?
            Console.WriteLine($"{s}\n{3}");
        }
    }
}