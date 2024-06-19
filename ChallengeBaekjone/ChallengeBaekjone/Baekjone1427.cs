using System;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone1427
    {
        public static void Problem()
        {
            var arr = Console.ReadLine().ToCharArray();
            Array.Sort(arr, (x, y) => y.CompareTo(x));
            Console.WriteLine(arr);
        }
    }
}