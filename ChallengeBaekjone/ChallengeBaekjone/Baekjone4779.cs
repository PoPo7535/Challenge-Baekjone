using System;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone4779
    {
        public void Problem()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                var len =  (int)Math.Pow(3, int.Parse(input));
                var sb = new StringBuilder(len);
                for (int i = 0; i < len; ++i)
                    sb.Append('-');
                Cal(sb, 0, sb.Length);
                Console.WriteLine(sb);
            }
        }
        public static void Cal(StringBuilder sb, int startIndex, int len)
        {
            if (len <= 1)
                return;
            len /= 3;
            for (int i = 0; i < len; ++i)
                sb[startIndex + len + i] = ' ';

            Cal(sb, startIndex, len);
            Cal(sb, startIndex + (len * 2), len);
        }
    }
}