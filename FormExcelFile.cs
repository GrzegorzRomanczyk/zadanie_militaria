using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XMLToExcel
{
    public partial class FormExcelFile : Form
    {
        ExcelOperations excelOperations = new ExcelOperations();
        public FormExcelFile()
        {
            InitializeComponent();

            try
            {
                excelOperations.ImportExcelFile(1, dataGridView1);
                excelOperations.ImportExcelFile(2, dataGridView2);
            }
            catch (Exception)
            {

                MessageBox.Show("Plik używany przez inna aplikacje!!");
            }
                 
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            excelOperations.ChangeCellsColor(e);
        }
    }
}
