using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = System.IO.File.ReadAllText("Inputs/day-12.txt");
            PipeGroupFinder f = new PipeGroupFinder(input);
            
            // Part one
            Console.WriteLine(f.FindGroupMemberCount(0));

            // Part two
            Console.WriteLine(f.FindNumberOfGroups());
        }
    }
}
