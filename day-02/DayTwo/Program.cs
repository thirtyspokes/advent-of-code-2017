using System;
using DayTwo.Services;
using DayTwo.Models;

namespace DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One
            FileSpreadsheetInputParser parser = new FileSpreadsheetInputParser();
            Spreadsheet sheet = parser.ParseInput("inputs/day-two.txt");
            Console.WriteLine(sheet.CalculateSubtractionChecksum());

            // Part Two
            Console.WriteLine(sheet.CalculateDivisionChecksum());
        }
    }
}
