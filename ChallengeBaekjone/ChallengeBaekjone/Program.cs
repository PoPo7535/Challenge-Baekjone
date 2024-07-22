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