using System;

namespace ChallengeBaekjone
{
    public struct Info : IComparable<Info>
    {
        public int age;
        public string name;
        public int number;
        public int CompareTo(Info other)
        {
            var ageCompareTo = age.CompareTo(other.age);
            if (ageCompareTo != 0)
                return ageCompareTo;
            return number.CompareTo(other.number);
        }
    }
    
    public class Baekjone10814
    {
        public static void Problem()
        {
            var N = int.Parse(Console.ReadLine());
            var info = new Info[N];
            for (int i = 0; i < N; ++i)
            {
                var input = Console.ReadLine().Split(' ');
                info[i] = new Info()
                {
                    age = int.Parse(input[0]),
                    name = input[1],
                    number = i
                };
            }
            Array.Sort(info);

            for (int i = 0; i < info.Length; ++i)
            {
                Console.WriteLine($"{info[i].age} {info[i].name}");
            }
        }
    }
}