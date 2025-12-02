namespace AdventOfCode2025
{
    internal class Program
    {
        private const string InputDir = @"D:\Annat\AdventOfCode2025\Input";
        
        static void Main(string[] args)
        {

        }

        private static string GetInput(int day)
        {
            string dayString = day.ToString("00");
            string inputFilePath = Path.Combine(InputDir, $"Day_{dayString}.txt");
            
            if (!File.Exists(inputFilePath)) 
                throw new FileNotFoundException($"Input file {inputFilePath} not found");
            
            return File.ReadAllText(inputFilePath);
        }

        private static void SolveDay(int day)
        {
            Console.WriteLine($"~*~ Day {day:00} ~*~\n");
            string input = GetInput(day);
            Console.WriteLine($"Part 1: {SolvePart1(1, input)}");
            Console.WriteLine($"Part 2: {SolvePart1(1, input)}\n");
        }

        private static string SolvePart1(int day, string input)
        {
            return day switch
            {
                _ => "Not Implemented"
            };
        }

        private static string SolvePart2(int day, string input)
        {
            return day switch
            {
                _ => "Not Implemented"
            };
        }
    }
}
