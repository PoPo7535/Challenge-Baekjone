using System;
using System.Linq;

namespace ChallengeBaekjone
{
    public class BaekJoon1120
    {
        void Problem()
        {
            var split = Console.ReadLine().Split(' ');
            var count = Math.Abs(split[0].Length - split[1].Length);
            var bigStr = split[0].Length < split[1].Length ? split[1] : split[0];
            var smallStr = split[0].Length < split[1].Length ? split[0] : split[1];
            var arr = new int[count + 1];
            for (int i = 0; i < smallStr.Length; i++)
            {
                for (int j = 0; j <= count; j++)
                {
                    if (bigStr[i + j] != smallStr[i])
                    {
                        ++arr[j];
                    }
                }
            }
            Console.WriteLine(arr.Min());
        }
    }
}