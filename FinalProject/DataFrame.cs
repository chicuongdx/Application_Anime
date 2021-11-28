using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace FinalProject
{
    class DataFrame
    {
        //Read datatable
        public static DataTable ReadExcel()
        {
            string url = Application.StartupPath + "\\Data.xlsx";

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            //if (excelApp == null)
            //{
            //    Console.WriteLine("Excel is not installed!!");
            //    return;
            //}

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            //Set DataTable Name and Columns Name
            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("NumEp", typeof(int));
            ///myTable.Columns.Add("Description", typeof(string));
            myTable.Columns.Add("NumMovie", typeof(int));
            myTable.Columns.Add("View", typeof(int));
            myTable.Columns.Add("Year", typeof(int));

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2); //string
                    myNewRow["NumEp"] = Convert.ToInt32(excelRange.Cells[i, 2].Value2); //int
                    myNewRow["NumMovie"] = Convert.ToInt32(excelRange.Cells[i, 3].Value2); //int
                    myNewRow["View"] = Convert.ToInt32(excelRange.Cells[i, 4].Value2); //int
                    myNewRow["Year"] = Convert.ToInt32(excelRange.Cells[i, 5].Value2); //Datetime

                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }
        public static DataTable DataSet = ReadExcel();

    }
}
