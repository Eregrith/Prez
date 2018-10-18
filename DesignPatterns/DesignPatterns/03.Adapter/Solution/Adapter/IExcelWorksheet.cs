namespace DesignPatterns.Adapter.Solution
{
    public interface IExcelWorksheet
    {
        IExcelCell GetCells(int x, int y);
        IExcelCell GetCells(string address);
    }
}