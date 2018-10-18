using OfficeOpenXml;

namespace DesignPatterns.Adapter.Solution.Adapter.Implementation
{
    internal class AdaptedWorksheets : IExcelWorksheets
    {
        private readonly ExcelWorksheets _worksheets;

        public AdaptedWorksheets(ExcelWorksheets worksheets)
        {
            _worksheets = worksheets;
        }

        public void Add(string mainSheetName)
        {
            _worksheets.Add(mainSheetName);
        }

        public IExcelWorksheet GetWorksheet(string name)
        {
            return new AdaptedWorksheet(_worksheets[name]);
        }
    }
}