using System;
using ExcelSheet = Microsoft.Office.Interop.Excel;

namespace SpecflowBasic.Utilities
{
	class Excel
	{
		public String readExcel(string filePath, int worksheetIndex, int column, int row)
		{
			ExcelSheet.Application xlApplication = new ExcelSheet.Application();
			ExcelSheet.Workbook xlWorkbook = xlApplication.Workbooks.Open(@filePath);
			ExcelSheet._Worksheet xlWorksheet = (ExcelSheet._Worksheet)xlWorkbook.Sheets[worksheetIndex];
			ExcelSheet.Range xlRange = xlWorksheet.UsedRange;
			Console.Write(xlRange.Cells[row, column].Value2.ToString());
			String value = xlRange.Cells[row, column].Value2.ToString();
			xlWorkbook.Close();
			xlApplication.Quit();
			return value;
		}

		public void writeExcel(string filePath, int worksheetIndex, int column, int row, String newvalue)
		{
			ExcelSheet.Application xlApplication = new ExcelSheet.Application();
			ExcelSheet.Workbook xlWorkbook = xlApplication.Workbooks.Open(@filePath);
			ExcelSheet._Worksheet xlWorksheet = (ExcelSheet._Worksheet)xlWorkbook.Sheets[worksheetIndex];
			ExcelSheet.Range xlRange = xlWorksheet.Rows.Cells[column, row];
			xlRange.Cells.Value = newvalue;
			xlWorkbook.Save();
			xlWorkbook.Close();
			xlApplication.Quit();
		}
	}
}