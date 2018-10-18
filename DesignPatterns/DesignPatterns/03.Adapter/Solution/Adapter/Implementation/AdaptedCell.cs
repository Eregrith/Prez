using OfficeOpenXml;

namespace DesignPatterns.Adapter.Solution.Adapter.Implementation
{
    internal class AdaptedCell : IExcelCell
    {
        private readonly ExcelRange _excelRange;

        public AdaptedCell(ExcelRange excelRange)
        {
            _excelRange = excelRange;
        }

        public object Value
        {
            get => _excelRange.Value;
            set => _excelRange.Value = value;
        }
    }
}