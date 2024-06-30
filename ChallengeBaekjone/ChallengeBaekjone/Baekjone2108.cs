using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone2108
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();
            var dic = new Dictionary<int, int>();
            var average = 0D;
            var min = int.MaxValue;
            var max = int.MinValue;
            for (int i = 0; i < N; ++i)
            {
                var input = int.Parse(Console.ReadLine());
                average += input;
                if (input < min)
                    min = input;
                if (max < input)
                    max = input;
                if (dic.ContainsKey(input))
                    ++dic[input];
                else
                    dic.Add(input, 1);
    
                list.Add(input);
            }
            list.Sort();
            var dicToList = dic.ToList();
            dicToList.Sort((a, b) =>
            {
                var compareTo= a.Value.CompareTo(b.Value);
                if (compareTo == 0)
                    compareTo = b.Key.CompareTo(a.Key);
                return compareTo;
            });
            var val =  1<dicToList.Count &&
                       (dicToList[dicToList.Count - 1].Value == dicToList[dicToList.Count - 2].Value)
                ? dicToList[dicToList.Count - 2].Key
                : dicToList[dicToList.Count - 1].Key;
            Console.Write($"" +
                          $"{RoundToTenths(average / N):0}\n" +
                          $"{list[list.Count / 2]}\n" +
                          $"{val}\n" +
                          $"{max - min}");
        }


        static int RoundToTenths(double value)
        {
            double scaledValue = value;
        
            // 양수의 경우
            if (scaledValue > 0)
                scaledValue = (int)(scaledValue + 0.5);
            // 음수의 경우
            else
                scaledValue = (int)(scaledValue - 0.5);
        
            // 다시 10으로 나누어 소수점 첫째 자리까지 반올림된 값으로 변환
            return (int)scaledValue;
        }
    }
}
