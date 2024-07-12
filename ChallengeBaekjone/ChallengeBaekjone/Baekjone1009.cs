using System;

namespace ChallengeBaekjone
{
    public class Baekjone1009
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            for (int t = 0; t < N; ++t)
            {
                var inputs = Console.ReadLine().Split();
                var a = int.Parse(inputs[0]);
                var b = int.Parse(inputs[1]);
                // a의 마지막 자리수만 고려
                a = a % 10;
                if (a == 0) 
                {
                    Console.WriteLine(10);
                    continue;
                }
                int result = 1;
                for (int i = 0; i < b; i++)
                    result = (result * a) % 10;
                Console.WriteLine(result);
            }
        }
    }
}