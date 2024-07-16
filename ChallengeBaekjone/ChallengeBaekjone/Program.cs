﻿using System;
using System.IO;

namespace ChallengeBaekjone
{
    internal class Program
    {
        static void Main()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var N = sr.ReadLine();
            var F = int.Parse(sr.ReadLine());
            var val = int.Parse(N.Substring(0, N.Length - 2)) * 100;
            var n = val % F;
            sw.WriteLine((F - n).ToString().PadLeft(2,'0'));
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