using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2025
{
    internal static class Day02
    {
        public static string Part1(string input)
        {
            string[] inputLines = input.Split(',');
            long total = 0;

            foreach (string line in inputLines)
            {
                string trimmedLine = line.Trim();
                
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                string[] parts = trimmedLine.Split('-');
                long start = long.Parse(parts[0]);
                long end = long.Parse(parts[1]);

                for (long i = start; i <= end; i++)
                {
                    if (!IsValidID(i)) total += i;
                }
            }

            return total.ToString();
        }

        public static string Part2(string input)
        {
            return "Not implemented";
        }

        private static bool IsValidID(long id)
        {
            string idString = id.ToString();
            int idLen = idString.Length;

            if (idLen % 2 != 0) return true; // Can't be mirrored if not even.

            int midPoint = idLen / 2;

            return idString[..midPoint] != idString[midPoint..]; // Invalid if mirrored.
        } 
    }
}
