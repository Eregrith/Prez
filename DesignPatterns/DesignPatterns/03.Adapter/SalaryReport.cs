using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SalaryReport
    {
        public SalaryReport()
        {
            
        }

        public void RenderToFile(string fileName)
        {
            var newFile = new FileInfo(fileName);
            using (ExcelPackage xlPackage = new ExcelPackage(newFile))
            {
                string mainSheetName = "Main sheet";
                xlPackage.Workbook.Worksheets.Add(mainSheetName);

                FillCells(xlPackage.Workbook.Worksheets[mainSheetName]);

                xlPackage.Save();
            }
        }

        private void FillCells(ExcelWorksheet excelWorksheet)
        {
            excelWorksheet.Cells[0, 0].Value = "Title";
            excelWorksheet.Cells[0, 1].Value = "Subtitle";

            excelWorksheet.Cells["A2:D5"].Value = "Big merged cell";
        }
    }
}
