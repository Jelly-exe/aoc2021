using System;
using System.Collections.Generic;
using System.IO;

namespace Day3.Part2
{
    class Program
    {
        static string Recursion(List<String> values, int index, string type)
        {
            List<string> newValues = new List<string>();
            var mostCommon = new Dictionary<char, int>() {{'0', 0}, {'1', 0}};

            for (int j = 0; j < values.Count; j++) mostCommon[values[j][index]] += 1;
            
            char lookingFor = ((mostCommon['0'] > mostCommon['1'] && type == "oxygen") ||
                          (mostCommon['1'] >= mostCommon['0'] && type == "CO2")) ? '0' : '1';
            
            foreach (var value in values) if (value[index] == lookingFor) newValues.Add(value);

            if (newValues.Count == 1) return newValues[0];
            return Recursion(newValues, index + 1, type);
        }
        static void Main(string[] args) {
            List<string> input = new List<string>(new StreamReader("../../../input.txt").ReadToEnd().Split("\n"));

            string oxygen = Recursion(input, 0, "oxygen");
            string co2 = Recursion(input, 0, "CO2");
            
            Console.WriteLine(Convert.ToInt32(oxygen, 2) * Convert.ToInt32(co2, 2));

        }
    }
}