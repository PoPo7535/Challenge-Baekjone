using System;

namespace ChallengeBaekjone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().ToCharArray();
            Array.Sort(arr, (x, y) => y.CompareTo(x));
            Console.WriteLine(arr);
        }
    }
}