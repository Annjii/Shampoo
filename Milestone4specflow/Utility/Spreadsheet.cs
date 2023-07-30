using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4specflow.Utility
{
    public class Spreadsheet
    {
        public static string excelRead(int rowNumber, int cellNumber)
        {
            String path = @"C:\Users\mindc1may266\Desktop\M1089290Milestone4\Milestone4specflow\Milestone4specflow\Utility\Spreadsheet.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0).GetRow(rowNumber).GetCell(cellNumber).StringCellValue.Trim();
            return sheet;
        }
    }
}
