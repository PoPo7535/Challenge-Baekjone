using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChallengeBaekjone
{
    public class Baekjone14725
    {
        static void Problem()
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());

            var N = int.Parse(sr.ReadLine());
            var root = new Node("");

            for (int i = 0; i < N; i++)
            {
                var input = sr.ReadLine().Split(' ');
                root.Add(input.Skip(1).ToArray());
            }

            root.Write(sw);

            sw.Flush();
            sw.Close();
            sr.Close();
        }

        public class Node
        {
            private string name;
            private Dictionary<string, Node> children;

            public Node(string name)
            {
                this.name = name;
                children = new Dictionary<string, Node>();
            }

            public void Add(string[] foods)
            {
                Node current = this;

                foreach (var food in foods)
                {
                    if (!current.children.ContainsKey(food))
                    {
                        current.children[food] = new Node(food);
                    }

                    current = current.children[food];
                }
            }

            public void Write(StreamWriter sw, int depth = 0)
            {
                var keys = children.Keys.ToList();
                keys.Sort();

                foreach (var key in keys)
                {
                    for (int i = 0; i < depth; i++)
                    {
                        sw.Write("--");
                    }

                    sw.WriteLine(key);
                    children[key].Write(sw, depth + 1);
                }
            }
        }
    }
}