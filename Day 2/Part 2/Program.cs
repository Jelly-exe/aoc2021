using System;
using System.Collections.Generic;
using System.IO;

namespace Day2.Part1
{
    class Program
    {
        static void Main(string[] args) {
            string[] input = new StreamReader("../../../input.txt").ReadToEnd().Split("\n");

            var submarine = new Dictionary<string, int>
            {
                {"hori", 0},
                {"depth", 0},
                {"aim", 0}
            };

            foreach (var value in input)
            {
                string[] split = value.Split(' ');

                switch (split[0])
                {
                    case "forward":
                        submarine["hori"] += int.Parse(split[1]);
                        submarine["depth"] += (submarine["aim"] * int.Parse(split[1]));
                        break;
                    case "up":
                        submarine["aim"] -= int.Parse(split[1]);
                        break;
                    case "down":
                        submarine["aim"] += int.Parse(split[1]);
                        break;
                } 
            }

            Console.WriteLine(submarine["depth"] * submarine["hori"]);

        }
    }
}