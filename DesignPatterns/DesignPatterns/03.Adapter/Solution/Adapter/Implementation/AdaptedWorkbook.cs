using OfficeOpenXml;

namespace DesignPatterns.Adapter.Solution.Adapter.Implementation
{
    internal class AdaptedWorkbook : IExcelWorkbook
    {
        private readonly ExcelWorkbook _workbook;

        public AdaptedWorkbook(ExcelWorkbook workbook)
        {
            _workbook = workbook;
            Worksheets = new AdaptedWorksheets(workbook.Worksheets);
        }

        public IExcelWorksheets Worksheets { get; private set; }
    }
}