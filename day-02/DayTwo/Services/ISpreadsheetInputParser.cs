using DayTwo.Models;

namespace DayTwo.Services
{
    public interface ISpreadsheetInputParser
    {
        Spreadsheet ParseInput(string input);
    }
}