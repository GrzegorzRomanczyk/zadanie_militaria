using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Xml2CSharp;

namespace XMLToExcel
{
    class XMLOperation
    {
        XmlSerializer xs;
        Produkty produkty;
        public XMLOperation()
        {
            xs = new XmlSerializer(typeof(Produkty));
        }
       
        public Produkty DeserializeXML()
        {
            FileStream fileStream = new FileStream(FilePathValues.xmlPath, FileMode.Open, FileAccess.Read);
            produkty = (Produkty)xs.Deserialize(fileStream);
            fileStream.Close();
            return produkty;
        }
        public List<ProduktBezZdjec> CopyDataToExport()
        {
            var obj= DeserializeXML();
            
            List<ProduktBezZdjec> nowaLista = new List<ProduktBezZdjec>();
            nowaLista = obj.Produkt.ConvertAll(x => new ProduktBezZdjec
            {
                Id = x.Id,
                Nazwa = x.Nazwa,
                Dlugi_opis = x.Dlugi_opis,
                Waga = x.Waga,
                Kod = x.Kod,
                Ean = x.Ean,
                Status = x.Status,
                Typ = x.Typ,
                Cena_zewnetrzna_hurt = x.Cena_zewnetrzna_hurt,
                Cena_zewnetrzna = x.Cena_zewnetrzna,
                Vat = x.Vat,
                Ilosc_wariantow = x.Ilosc_wariantow,
                ilosc_zdjec = x.ilosc_zdjec,
                Marza = x.Marza
            });
            return nowaLista;
        }
        public List<DoZdjec>FillDataToEport()
        {
            var obj = DeserializeXML();

            List<DoZdjec> listaZdjec = new List<DoZdjec>();

            foreach (var item in obj.Produkt)
            {
                var y = item.Zdjecia.Zdjecie;
                foreach (var ite in y)
                {
                    listaZdjec.Add(new DoZdjec(item.Id, ite.Text));
                }
            }
            return listaZdjec;
        }
        public bool ExportToExcel(List<ProduktBezZdjec> list, string file, string sheetName, string sheetName2)
        {
           
            bool exported = false;
            using (var workbook = new XLWorkbook())
            {
                try
                {
                    var ws = workbook.AddWorksheet(sheetName).FirstCell().InsertTable(list, false);
                    workbook.AddWorksheet(sheetName2).FirstCell().InsertTable(FillDataToEport(), false);
                    ws.Column(4).Delete();
                    ws.Column("N").AddConditionalFormat().WhenLessThan(20).Fill.BackgroundColor = XLColor.Orange;
                    ws.Column("M").AddConditionalFormat().WhenLessThan(2).Fill.BackgroundColor = XLColor.Red;
                }
                catch (Exception)
                {
                }
                workbook.SaveAs(file);
                exported = true;
            }
            return exported;
        }


    }
}
