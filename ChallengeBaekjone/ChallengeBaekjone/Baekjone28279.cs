using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChallengeBaekjone
{
    public class Baekjone28279
    {
        public static void Problem()
        {
            var deck = new LinkedList<int>();
            var N = int.Parse(Console.ReadLine());
            using (var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, bufferSize: 1024))
            {
                for (int i = 0; i < N; ++i)
                {
                    var input = Console.ReadLine().Split(' ');
                    var commend = int.Parse(input[0]);
                    switch (commend)
                    {
                        case 1:
                            deck.AddFirst(int.Parse(input[1]));
                            break;
                        case 2:
                            deck.AddLast(int.Parse(input[1]));
                            break;
                        case 3:
                            writer.WriteLine(deck.Count == 0 ? -1 : deck.First.Value);
                            if (deck.Count != 0)
                                deck.RemoveFirst();
                            break;
                        case 4:
                            writer.WriteLine(deck.Count == 0 ? -1 : deck.Last.Value);
                            if (deck.Count != 0)
                                deck.RemoveLast();
                            break;
                        case 5:
                            writer.WriteLine(deck.Count);
                            break;
                        case 6:
                            writer.WriteLine(deck.Count == 0 ? 1 : 0);
                            break;
                        case 7:
                            writer.WriteLine(deck.Count == 0 ? -1 : deck.First.Value);
                            break;
                        case 8:
                            writer.WriteLine(deck.Count == 0 ? -1 : deck.Last.Value);
                            break;
                    }
                }
            }
        }
    }
}