using System;

namespace ChallengeBaekjone
{
    public class Baekjone1085
    {
        public static void Problem()
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var x = arr[0] < arr[2] - arr[0] ? arr[0] : arr[2] - arr[0];  
            var y = arr[1] < arr[3] - arr[1] ? arr[1] : arr[3] - arr[1];
            Console.WriteLine(x < y ? x : y);
        }
    }
}