using System;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var str= Console.ReadLine().Split();
            var N = int.Parse(str[0]);
            var M = int.Parse(str[1]);
            var max = int.MinValue;
            StringBuilder sb ;
            for (int i = 1; i <= M; ++i)
            {
                var val = 0;
                sb = new StringBuilder((N * i).ToString());
                for (int j = 0; j < sb.Length; ++j)
                    val += (int)Math.Pow(10, sb.Length - j) * (sb[sb.Length -j- 1] - '0');
                val /= 10;
                if (max < val)
                    max = val;
            }
            Console.WriteLine(max);
            
            
            // var N = int.Parse(sr.ReadLine());
            // var arr = new int[N, N];
            // var size = N;
            //
            // var check = false;
            // while (check == false)
            // {
            //     for (int yPos = 0; yPos < N; yPos += size)
            //     {
            //         for (int xPos = 0; xPos < N; xPos += size)
            //         {
            //             var isWhite = arr[yPos, xPos] == 0;
            //             var isCut = false;
            //             for (int y = yPos; y < yPos + size; ++y) 
            //             {
            //                 for (int x = xPos; x < xPos + size; ++x) 
            //                 {
            //                     
            //                 }
            //             }
            //         }
            //     }
            //
            //     if (size == 1)
            //         break;
            //     size /= 2;
            // }
            //
            sr.Close();
            sw.Close();
        }
    }
}


/*
 * var sr = new StreamReader(Console.OpenStandardInput());
 * var sw = new StreamWriter(Console.OpenStandardOutput());
 * sr.Close();
 * sw.Close();
 */