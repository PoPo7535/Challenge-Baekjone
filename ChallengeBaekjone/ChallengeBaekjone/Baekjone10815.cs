using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone10815
    {
        public static void Problem()
        {
            var aCount = int.Parse(Console.ReadLine());
            var split = Console.ReadLine().Split(' ');
            
            var aNumbers = new HashSet<int>();
            for (int i = 0; i < aCount; ++i)
                aNumbers.Add(int.Parse(split[i]));
            
            var bCount = int.Parse(Console.ReadLine());
            split = Console.ReadLine().Split(' ');
            var bNumbers = new int[bCount];
            
            for (int i = 0; i < bCount; ++i)
                bNumbers[i] = int.Parse(split[i]);
            
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < bNumbers.Length; ++i)
                {
                    var result = aNumbers.Contains(bNumbers[i]) ? 1 : 0;
                    writer.Write($"{result} ");
                }
            }
        }
    }
}