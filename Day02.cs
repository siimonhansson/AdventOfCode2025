using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2025
{
    internal static class Day02
    {
        public static string Part1(string input) => GetTotal(input, IsValidID_Part1);

        public static string Part2(string input) => GetTotal(input, IsValidID_Part2);

        private static string GetTotal(string input, Func<long, bool> validCheck)
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
                    if (!validCheck(i)) total += i;
                }
            }

            return total.ToString();
        }

        private static bool IsValidID_Part1(long id)
        {
            string idString = id.ToString();
            int idLen = idString.Length;

            if (idLen % 2 != 0) return true; // Can't be mirrored if not even.

            int midPoint = idLen / 2;

            return idString[..midPoint] != idString[midPoint..]; // Invalid if mirrored.
        } 

        private static bool IsValidID_Part2(long id)
        {
            string idString = id.ToString();
            int idLen = idString.Length;

            for (int patternLen = 1; patternLen <= idLen / 2; patternLen++)
            {
                if (idLen % patternLen != 0) continue; // Can't be mirrored if not even.

                string patternString = idString[.. patternLen];

                bool isRepeating = true;

                for (int i = patternLen; i < idLen; i += patternLen)
                {
                    string segment = idString.Substring(i, patternLen);
                    if (segment != patternString)
                    {
                        isRepeating = false;
                        break; 
                    }
                }

                if (isRepeating) return false;
            }

            return true;
        } 
    }
}
