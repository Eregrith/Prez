namespace DesignPatterns.Adapter.Solution
{
    public interface IExcelWorkbook
    {
        IExcelWorksheets Worksheets { get; }
    }
}