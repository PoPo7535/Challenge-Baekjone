using System;

namespace ChallengeBaekjone
{
    public class Baekjone1436
    {
        public static void Problem1436()
        {
            var N = int.Parse(Console.ReadLine());
            var num = 0;
            var count = 0;
            while (N != count)
            {
                ++num;
                if (num.ToString().Contains("666"))
                {
                    ++count;
                }
            }
            
            Console.WriteLine(num);
        }
    }
    
}