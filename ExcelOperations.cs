using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLToExcel
{
   public class ExcelOperations
   {
        public void ImportExcelFile(int workSeetNumber, DataGridView dataGridView)
        {
            
                var workbook = new XLWorkbook(FilePathValues.excelPath);
                var ws = workbook.Worksheet(workSeetNumber);
                DataTable dataTable = new DataTable();

                int columnsCounter = ws.Columns().Count();
                int rowCounter = ws.Rows().Count();
                for (int i = 1; i <= columnsCounter; i++)
                {
                    dataTable.Columns.Add(ws.Cell(1, i).Value.ToString());
                }

                for (int i = 2; i <= rowCounter; i++)
                {
                    DataRow row = dataTable.NewRow();
                    for (int j = 1; j <= columnsCounter; j++)
                    {
                        row[ws.Cell(1, j).Value.ToString()] = ws.Cell(i, j).Value.ToString();
                    }
                    dataTable.Rows.Add(row);
                }
                dataGridView.DataSource = dataTable;
        }
        public void ChangeCellsColor(DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 13 && e.Value != null)
                {
                    decimal marza = Convert.ToDecimal(e.Value);
                    if (marza < 20)
                        e.CellStyle.BackColor = Color.Orange;
                }
                if (e.ColumnIndex == 12 && e.Value != null)
                {
                    int photoCount = Convert.ToInt32(e.Value);
                    if (photoCount < 2)
                        e.CellStyle.BackColor = Color.Red;
                }
            }
            catch (Exception)
            {
            }
        }
   }
}
