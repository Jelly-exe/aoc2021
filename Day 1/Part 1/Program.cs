using System;
using System.IO;

namespace Day1.Part1
{
    class Program
    {
        static void Main(string[] args) {
            string[] input = new StreamReader("../../../input.txt").ReadToEnd().Split("\n");

            int total = 0;

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (int.Parse(input[i]) < int.Parse(input[i + 1]))
                {
                    total += 1;
                }
            }

            Console.WriteLine(total);

        }
    }
}