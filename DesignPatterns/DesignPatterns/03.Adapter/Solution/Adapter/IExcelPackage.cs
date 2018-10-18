using System;

namespace DesignPatterns.Adapter.Solution
{
    public interface IExcelPackage : IDisposable
    {
        IExcelWorkbook Workbook { get; }
        void Save();
    }
}