using System;
using System.IO;
using System.Linq;
using System.Text;
using OfficeOpenXml;

namespace _06.EXCELlent_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(
                new FileInfo("../../sample_table.xlsx")))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First();
                var totalRows = myWorksheet.Dimension.End.Row;
                var totalColumns = myWorksheet.Dimension.End.Column;

                var sb = new StringBuilder();

                for (int rowNum = 1; rowNum <= totalRows; rowNum++)
                {
                    var row = myWorksheet
                        .Cells[rowNum, 1, rowNum, totalColumns]
                        .Select(c => c.Value?.ToString() ?? string.Empty);

                    if (row.Any(x => x != string.Empty))
                    {
                        sb.AppendLine(string.Join("|", row) + "|");
                    }
                }

                Console.WriteLine(sb.ToString());

                xlPackage.Dispose();
            }
        }
    }
}
