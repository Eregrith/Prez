using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Solution.Adapter.Implementation
{
    public class AdaptedExcelPackage : IExcelPackage
    {
        private readonly ExcelPackage _package;

        public AdaptedExcelPackage(FileInfo file)
        {
            _package = new ExcelPackage(file);
            Workbook = new AdaptedWorkbook(_package.Workbook);
        }

        public IExcelWorkbook Workbook { get; private set; }

        public void Dispose()
        {
            _package.Dispose();
        }

        public void Save()
        {
            _package.Save();
        }
    }
}
