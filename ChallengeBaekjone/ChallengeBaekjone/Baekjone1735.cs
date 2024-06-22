using System;

namespace ChallengeBaekjone
{
    public class Baekjone1735
    {
        public static void Problem()
        {
            var a = Console.ReadLine().Split(' ');
            var b = Console.ReadLine().Split(' ');
            var a1 = int.Parse(a[0]);
            var a2 = int.Parse(a[1]);
            var b1 = int.Parse(b[0]);
            var b2 = int.Parse(b[1]);
            var lcm = LCM(a2, b2);
            var newNum1 = a1 * (lcm / a2);
            var newNum2 = b1 * (lcm / b2);
            var sumNum = newNum1 + newNum2;


            var gcd = GCD(sumNum, lcm);
            var simplifiedNum = sumNum / gcd;
            var simplifiedDenom = lcm / gcd;
            Console.WriteLine($"{simplifiedNum} {simplifiedDenom}"); 
            int LCM(int A, int B)
            {
                return (A * B) / GCD(A, B);
            }
            int GCD(int A, int B)
            {
                while (B != 0)
                {
                    var temp = B;
                    B = A % B;
                    A = temp;
                }
                return A;
            }
        }
    }


}