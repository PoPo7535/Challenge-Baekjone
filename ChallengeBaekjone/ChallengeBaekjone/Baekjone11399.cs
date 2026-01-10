using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone11399
    {
        void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var t = int.Parse(sr.ReadLine());
            var inputs = sr.ReadLine().Split(' ');
            var arr = new int[t];
            for (int i = 0; i < t; i++)
                arr[i] = int.Parse(inputs[i]);
            Array.Sort(arr);
            int sum = 0;
            int time = 0;
            for (int i = 0; i < t; i++)
            {
                time += arr[i];
                sum += time;
            }
            Console.WriteLine(sum);
            sr.Close();
            sw.Close();
        }
    }
}