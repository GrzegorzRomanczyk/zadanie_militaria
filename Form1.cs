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
using System.Xml.Serialization;
using ClosedXML.Excel;
using Xml2CSharp;

namespace XMLToExcel
{
    public partial class Form1 : Form
    {
        XMLOperation xmlOperation = new XMLOperation();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            var obj = xmlOperation.DeserializeXML();
            dataGridView1.DataSource = obj.Produkt;
        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            if (File.Exists(FilePathValues.excelPath))
            {
                MessageBox.Show("plik istnieje");
                return;
            }
            xmlOperation.ExportToExcel(xmlOperation.CopyDataToExport(), FilePathValues.excelPath,"dane","zdjecia");     
        }
       

          private void button1_Click(object sender, EventArgs e)
          {
            if (File.Exists(FilePathValues.excelPath))
            {
                FormExcelFile form = new FormExcelFile();
                form.Show();
            }
            else
            {
                MessageBox.Show("Plik nie istnieje");
            }
        }
    }
}

