using System.IO;

namespace DesignPatterns.Adapter.Solution
{
    public interface IFileHelper
    {
        FileInfo GetFileInfo(string fileName);
    }
}