using System;
using System.IO;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var str = new[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            var days = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var input = Console.ReadLine().Split();
            var x = int.Parse(input[0]);
            var day = int.Parse(input[1]);
            for (int i = 0; i < x - 1; ++i)
                day += days[i];
            Console.WriteLine(str[day % 7]);


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