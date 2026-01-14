using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeBaekjone.Properties
{
    public class Baekjone1764
    {
        public static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var hash = new HashSet<string>();
            var list = new List<string>();
            var input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < input[0]; i++)
            {
                var str = sr.ReadLine();
                hash.Add(str);
            }   
            for (int i = 0; i < input[1]; i++)
            {
    
                var str = sr.ReadLine();
                if(hash.Contains(str))
                   list.Add(str); 
            } 
            list.Sort();
        }
    }
}