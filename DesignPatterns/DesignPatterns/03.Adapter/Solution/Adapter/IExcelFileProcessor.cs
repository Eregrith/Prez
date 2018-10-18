using System.IO;

namespace DesignPatterns.Adapter.Solution
{
    public interface IExcelFileProcessor
    {
        IExcelPackage CreatePackage(FileInfo newFile);
    }
}