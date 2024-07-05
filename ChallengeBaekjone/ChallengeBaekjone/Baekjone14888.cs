using System;

namespace ChallengeBaekjone
{
    public class Baekjone14888
    {
        static int N;
        static int[] numbers;
        static int[] operators; 
        static int maxValue = int.MinValue;
        static int minValue = int.MaxValue;
        public static void Problem()
        {
            N = int.Parse(Console.ReadLine());
            numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            operators = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Backtrack(numbers[0], 1);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
        static void Backtrack(int curVal, int index)
        {
            if (index == N)
            {
                maxValue = Math.Max(maxValue, curVal);
                minValue = Math.Min(minValue, curVal);
                return;
            }
            for (int i = 0; i < 4; ++i)
            {
                if (operators[i] <= 0) 
                    continue;
                --operators[i];
                if (i == 0)
                    Backtrack(curVal + numbers[index], index + 1);
                else if (i == 1)
                    Backtrack(curVal - numbers[index], index + 1);
                else if (i == 2)
                    Backtrack(curVal * numbers[index], index + 1);
                else if (i == 3)
                    Backtrack(curVal / numbers[index], index + 1);
                ++operators[i];
            }
        }
    }
}