using System;

namespace ChallengeBaekjone
{
    public class Baekjone17103
    {
        public static void Problem()
        {
            var max = 1000000;
            var table = new bool[max + 1];
            for (int i = 2; i * i <= max; i++)
                if (false == table[i])
                    for (int multiple = i * i; multiple <= max; multiple += i)
                        table[multiple] = true;
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; ++i)
            {
                var input = int.Parse(Console.ReadLine());
                int count = 0;
                for (int j = 2; j <= input / 2; ++j)
                    if (false == table[j] && false == table[input - j])
                        ++count;
                Console.WriteLine(count);
            }
        }
    }
}