using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2025
{
    internal static class Day01
    {
        public static string Part1(string input)
        {
            int currentPos = 50;
            int timesAtZero = 0;

            string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                char direction = trimmedLine[0];
                int distance = int.Parse(trimmedLine[1..]);

                if (direction == 'R')
                {
                    currentPos = (currentPos + distance) % 100;
                }
                else if (direction == 'L')
                {
                    currentPos = (currentPos - distance) % 100;
                    if (currentPos < 0) currentPos += 100;
                }

                if (currentPos == 0) timesAtZero++;
            }

            return timesAtZero.ToString();
        }

        public static string Part2(string input)
        {
            return " ";
        }

    }
}
