using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Solution
{
    public class SalaryReport
    {
        private readonly IFileHelper _fileHelper;
        private readonly IExcelFileProcessor _excelFileProcessor;

        public SalaryReport(IFileHelper fileHelper, IExcelFileProcessor excelFileProcessor)
        {
            _fileHelper = fileHelper;
            _excelFileProcessor = excelFileProcessor;
        }

        public void RenderToFile(string fileName)
        {
            var newFile = _fileHelper.GetFileInfo(fileName);
            using (IExcelPackage xlPackage = _excelFileProcessor.CreatePackage(newFile))
            {
                string mainSheetName = "Main sheet";
                xlPackage.Workbook.Worksheets.Add(mainSheetName);

                FillCells(xlPackage.Workbook.Worksheets.GetWorksheet(mainSheetName));

                xlPackage.Save();
            }
        }

        private void FillCells(IExcelWorksheet excelWorksheet)
        {
            excelWorksheet.GetCells(0, 0).Value = "Title";
            excelWorksheet.GetCells(0, 1).Value = "Subtitle";

            excelWorksheet.GetCells("A2:D5").Value = "Big merged cell";
        }
    }
}
