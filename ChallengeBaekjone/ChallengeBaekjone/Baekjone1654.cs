using System;

namespace ChallengeBaekjone
{
    public class Baekjone1654
    {
        void Problem()
        {
            var input = Console.ReadLine().Split(' ');
            int K = int.Parse(input[0]);
            int N = int.Parse(input[1]);
            int[] arr = new int[K];
            long max = 0;
            for (int i = 0; i < K; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max)
                    max = arr[i];
            }
            long left = 1;
            long right = max;
            long result = 0;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                long count = 0;
                foreach (var len in arr)
                    count += len / mid;
                if (count >= N)
                {
                    result = mid;   
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}