using System;

namespace ChallengeBaekjone
{
    public class Baekjone4134
    {
        public static void Problem()
        {
            var N = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < N; ++i)
            {
                var input = uint.Parse(Console.ReadLine());
                while (false == Check(input))
                    ++input;        
                Console.WriteLine(input);
            }
            bool Check(uint val)
            {
                if (0 == val || 1 == val)
                    return false;
                var max = Math.Sqrt(val);
                for (uint x = 2; x <= max; ++x)
                    if (val % x == 0)
                        return false;
                return true;
            }
        }
    }
}