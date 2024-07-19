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

            var arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            var x = arr[0] < arr[2] - arr[0] ? arr[0] : arr[2] - arr[0];  
            var y = arr[1] < arr[3] - arr[1] ? arr[1] : arr[3] - arr[1];
            sw.WriteLine(x < y ? x : y);
            
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