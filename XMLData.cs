/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	public class DoZdjec
    {
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
        public DoZdjec(string id, string text)
        {
			this.Id = id;
			this.Text = text;
        }
	}


	[XmlRoot(ElementName = "zdjecie")]
	public class Zdjecie
	{
		[XmlAttribute(AttributeName = "pozycja")]
		public string Pozycja { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "zdjecia")]
	public class Zdjecia
	{
		[XmlElement(ElementName = "zdjecie")]
		public List<Zdjecie> Zdjecie { get; set; }
	}

	[XmlRoot(ElementName = "produkt")]
	public class Produkt
	{
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "nazwa")]
		public string Nazwa { get; set; }
		[XmlElement(ElementName = "dlugi_opis")]
		public string Dlugi_opis { get; set; }
		[XmlElement(ElementName = "dane_techniczne")]
		public string Dane_techniczne { get; set; }
		[XmlElement(ElementName = "waga")]
		public string Waga { get; set; }
		[XmlElement(ElementName = "zdjecia")]
		public Zdjecia Zdjecia { get; set; }
		[XmlElement(ElementName = "kod")]
		public string Kod { get; set; }
		[XmlElement(ElementName = "ean")]
		public string Ean { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "typ")]
		public string Typ { get; set; }
		[XmlElement(ElementName = "cena_zewnetrzna_hurt")]
		public decimal Cena_zewnetrzna_hurt { get; set; }
		[XmlElement(ElementName = "cena_zewnetrzna")]
		public decimal Cena_zewnetrzna { get; set; }
		[XmlElement(ElementName = "vat")]
		public string Vat { get; set; }
		[XmlElement(ElementName = "ilosc_wariantow")]
		public string Ilosc_wariantow { get; set; }
        public int ilosc_zdjec
        {
            get { return Zdjecia.Zdjecie.Count; }
            set { ilosc_zdjec = value; }
        }
        private decimal marza;
        public decimal Marza
        {
            get { return (Cena_zewnetrzna - Cena_zewnetrzna_hurt) / Cena_zewnetrzna * 100; }
            set
            {
                marza = value;
            }
        }
    }

	[XmlRoot(ElementName = "produkty")]
	public class Produkty
	{
		[XmlElement(ElementName = "produkt")]
		public List<Produkt> Produkt { get; set; }
	}

	public class ProduktyBezZdjec
	{
		[XmlElement(ElementName = "produkt")]
		public List<ProduktBezZdjec> ProduktBezZdjec { get; set; }
	}
	public class ProduktBezZdjec
	{
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "nazwa")]
		public string Nazwa { get; set; }
		[XmlElement(ElementName = "dlugi_opis")]
		public string Dlugi_opis { get; set; }
		[XmlElement(ElementName = "dane_techniczne")]
		public string Dane_techniczne { get; set; }
		[XmlElement(ElementName = "waga")]
		public string Waga { get; set; }
		[XmlElement(ElementName = "zdjecia")]
		
		public string Kod { get; set; }
		[XmlElement(ElementName = "ean")]
		public string Ean { get; set; }
		[XmlElement(ElementName = "status")]
		public string Status { get; set; }
		[XmlElement(ElementName = "typ")]
		public string Typ { get; set; }
		[XmlElement(ElementName = "cena_zewnetrzna_hurt")]
		public decimal Cena_zewnetrzna_hurt { get; set; }
		[XmlElement(ElementName = "cena_zewnetrzna")]
		public decimal Cena_zewnetrzna { get; set; }
		[XmlElement(ElementName = "vat")]
		public string Vat { get; set; }
		[XmlElement(ElementName = "ilosc_wariantow")]
		public string Ilosc_wariantow { get; set; }
        public int ilosc_zdjec { get; set; }
        private decimal marza;
		public decimal Marza
		{
			get { return (Cena_zewnetrzna - Cena_zewnetrzna_hurt) / Cena_zewnetrzna * 100; }
			set
			{
				marza = value;
			}
		}
	}

}
