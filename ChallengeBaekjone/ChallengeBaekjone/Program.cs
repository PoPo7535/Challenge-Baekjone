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