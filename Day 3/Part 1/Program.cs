using System;
using System.Collections.Generic;
using System.IO;

namespace Day3.Part1
{
    class Program
    {
        static void Main(string[] args) {
            string[] input = new StreamReader("../../../input.txt").ReadToEnd().Split("\n");

            string gammaRate = "";
            string epsilonRate = "";
            
            for (int i = 0; i < input[0].Length; i++)
            {
                var mostCommon = new Dictionary<char, int>() {{'0', 0}, {'1', 0}};

                for (int j = 0; j < input.Length; j++) mostCommon[input[j][i]] += 1;

                gammaRate += mostCommon['0'] > mostCommon['1'] ? "0" : "1";
                epsilonRate += mostCommon['0'] > mostCommon['1'] ? "1" : "0";
            }

            Console.WriteLine(Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2));

        }
    }
}