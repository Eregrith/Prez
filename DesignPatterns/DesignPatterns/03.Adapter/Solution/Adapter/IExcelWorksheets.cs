namespace DesignPatterns.Adapter.Solution
{
    public interface IExcelWorksheets
    {
        void Add(string mainSheetName);
        IExcelWorksheet GetWorksheet(string name);
    }
}