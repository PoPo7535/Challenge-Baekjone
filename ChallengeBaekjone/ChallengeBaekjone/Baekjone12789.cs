using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone12789
    {
        public static void Problem()
        {
            var queueLine = new Queue<int>();
            var stackLine = new Stack<int>();
            var N = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; ++i) 
                queueLine.Enqueue(int.Parse(numbers[i]));
            for (int i = 1; i < N + 1;)
            {
                if (0 != queueLine.Count && i == queueLine.Peek())
                {
                    queueLine.Dequeue();
                    ++i;
                }
                else if (0 != stackLine.Count && i == stackLine.Peek())
                {
                    stackLine.Pop();
                    ++i;
                }
                else if (0 != queueLine.Count)
                {
                    stackLine.Push(queueLine.Dequeue());
                }
                else
                {
                    Console.WriteLine("Sad");
                    return;
                }
            }
            Console.WriteLine("Nice");
        }
    }
}