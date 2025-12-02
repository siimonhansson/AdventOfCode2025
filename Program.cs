namespace AdventOfCode2025
{
    internal class Program
    {
        private const string InputDir = @"D:\Annat\AdventOfCode2025\Input";
        
        static void Main(string[] args)
        {

        }

        private static string GetInput(int day, int part)
        {
            string dayString = day.ToString("00");
            string inputFilePath = Path.Combine(InputDir, $"Day_{dayString}_{part}.txt");
            
            if (!File.Exists(inputFilePath)) 
                throw new FileNotFoundException($"Input file {inputFilePath} not found");
            
            return File.ReadAllText(inputFilePath);
        }
    }
}
