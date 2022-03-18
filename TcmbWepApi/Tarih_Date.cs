using System.Xml.Serialization;

namespace TcmbWepApi

{
    [XmlRoot(ElementName = "Tarih_Date")]
	public class Tarih_Date
	{
		[XmlElement(ElementName = "Currency")]
		public List<Currency> Currency { get; set; }
		[XmlAttribute(AttributeName = "Tarih")]
		public string Tarih { get; set; }
		[XmlAttribute(AttributeName = "Date")]
		public string Date { get; set; }
		[XmlAttribute(AttributeName = "Bulten_No")]
		public string Bulten_No { get; set; }
	}

}

