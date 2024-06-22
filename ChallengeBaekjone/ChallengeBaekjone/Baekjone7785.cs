using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone7785
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var hashSet = new HashSet<string>();
            for (int i = 0; i < N; ++i)
            {
                var str = Console.ReadLine().Split(' ');
                if (str[1] == "enter")
                    hashSet.Add(str[0]);
                else
                    hashSet.Remove(str[0]);
            }
            var list = new List<string>(hashSet);
            list.Sort();
            list.Reverse();
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    writer.WriteLine($"{list[i]}");
                }
            }
        }
    }
}