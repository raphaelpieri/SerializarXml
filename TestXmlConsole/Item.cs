using System;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    [XmlType(TypeName = "item")]
    public class Item
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("nome")]
        public string Nome { get; set; }

        public Item()
        {

        }
    }
}