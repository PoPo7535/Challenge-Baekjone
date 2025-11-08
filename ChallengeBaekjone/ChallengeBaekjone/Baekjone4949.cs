using System;
using System.Collections.Generic;

namespace ChallengeBaekjone
{
    public class Baekjone4949
    {
        public static void Problem()
        {
            while (true)
            {
                var str = Console.ReadLine();
                if (str == ".")
                    return;
                var stack = new Stack<int>();
                foreach (var t in str)
                {
                    switch (t)
                    {
                        case '[':
                            stack.Push(1);
                            break;
                        case ']':
                            if (stack.Count == 0 || 1 != stack.Pop())
                            {
                                Console.WriteLine("no");
                                goto end;
                            }
                            break;
                        case '(':
                            stack.Push(2);
                            break;
                        case ')':
                            if (stack.Count == 0 || 2 != stack.Pop())
                            {
                                Console.WriteLine("no");
                                goto end;
                            }
                            break;
                    }
                }
                Console.WriteLine(stack.Count == 0 ? "yes" : "no");
                end:;
            }
        }
    }
}