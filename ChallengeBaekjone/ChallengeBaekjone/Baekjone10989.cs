using System;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone10989
    {
        public static void Problem()
        {
            var count = new int[10001];
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; ++i)
                ++count[int.Parse(Console.ReadLine())];
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < count.Length; ++i)
                {
                    if (0 != count[i])
                    {
                        for (int j = 0; j < count[i]; ++j)
                            writer.WriteLine(i);
                    }
                }
            }
        }
    }
}