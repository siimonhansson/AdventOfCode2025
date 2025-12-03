using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2025
{
    internal static class Day03
    {
        public static string Part1(string input)
        {
            string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int totalJoltage = 0;

            foreach (string bank in lines)
            {
                int maxJoltage = 0;

                for (int i = 0; i < bank.Length - 1; i++) 
                {
                    for (int j = i + 1; j < bank.Length; j++) 
                    {
                        int joltage = int.Parse($"{bank[i]}{bank[j]}");
                        maxJoltage = Math.Max(maxJoltage, joltage);
                    }
                }

                totalJoltage += maxJoltage;
            }

            return totalJoltage.ToString();
        }

        public static string Part2(string input)
        {
            return "Not implemented";
        }
    }
}
