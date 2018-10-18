using OfficeOpenXml;

namespace DesignPatterns.Adapter.Solution.Adapter.Implementation
{
    internal class AdaptedWorksheet : IExcelWorksheet
    {
        private readonly ExcelWorksheet _excelWorksheet;

        public AdaptedWorksheet(ExcelWorksheet excelWorksheet)
        {
            _excelWorksheet = excelWorksheet;
        }

        public IExcelCell GetCells(int x, int y)
        {
            return new AdaptedCell(_excelWorksheet.Cells[y, x]);
        }

        public IExcelCell GetCells(string address)
        {
            return new AdaptedCell(_excelWorksheet.Cells[address]);
        }
    }
}