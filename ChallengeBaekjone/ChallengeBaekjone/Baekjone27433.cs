using System;

namespace ChallengeBaekjone
{
    public class Baekjone27433
    {
        public static void Problem()
        {
            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));   
        }
        static long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}