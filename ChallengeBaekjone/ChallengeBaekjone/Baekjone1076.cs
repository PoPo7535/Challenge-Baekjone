using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone1076
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            var color1 = Console.ReadLine();
            var color2 = Console.ReadLine();
            var color3 = Console.ReadLine();
            var value1 = Array.IndexOf(colors, color1);
            var value2 = Array.IndexOf(colors, color2);
            var multiplier = Array.IndexOf(colors, color3);
            var resistance = (value1 * 10 + value2) * (long)Math.Pow(10, multiplier);
            Console.WriteLine(resistance);
            sr.Close();
            sw.Close();
        }
    }
}