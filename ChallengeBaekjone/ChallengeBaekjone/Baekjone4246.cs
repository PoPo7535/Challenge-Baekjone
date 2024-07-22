using System;
using System.IO;

namespace ChallengeBaekjone
{
    public class Baekjone4246
    {
        static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());


            while (true)
            {
                var size = int.Parse(sr.ReadLine());
                
                if(size == 0)
                    break;

                var str = sr.ReadLine();
                var arr = new char[str.Length / size, size];
                for (int i = 0; i < str.Length; ++i)
                {
                    var a = i / size;
                    var b = i % size;
                    arr[i == 0 ? 0 : a, 
                        a % 2 == 0 ? b : size - b - 1] = str[i];
                }

                for (int x = 0; x < size; ++x)
                    for (int y = 0; y < str.Length / size; ++y) 
                        sw.Write(arr[y,x]);
                sw.WriteLine();
            }
            sr.Close();
            sw.Close();
        }
    }
}