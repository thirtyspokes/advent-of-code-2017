using System;
using Day8.Models;
using Day8.Services;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU(); 
            FileInputReader reader = new FileInputReader();
            InstructionProcessor processor = new InstructionProcessor(cpu, reader);
            processor.ProcessInstructions("Inputs/day-8.txt");

            // Part one
            Console.WriteLine(processor.GetCurrentLargestValue());
            
            // Part two
            Console.WriteLine(processor.GetHistoricalLargestValue());
        }
    }
}
