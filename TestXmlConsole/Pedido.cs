using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    [XmlType(TypeName ="pedido")]
    public class Pedido : XML<Pedido>
    {
        [XmlElement("id")]
        public int ID { get; set; }

        [XmlIgnore]
        public  string Filial { set; get; }
        [XmlIgnore]
        public string Numero { set; get;  }
        [XmlIgnore]
        public string Serie { set; get; }

        [XmlElement("numeroDoPedido")]
        public string NumeroPedido { get { return string.Format("{0}-{1}-{2}", this.Filial, this.Serie, this.Numero); } set { }  }
        
        [XmlArray("itens")]
       // [XmlArrayItem(ElementName = "item")]     
        public List<Item> Itens { get; set; }

        [XmlElement("quantidade")]
        public decimal Quantidade { get; set; }

        [XmlElement("versao")]
        public string Versao { get; set; }

        public override XmlSerializerNamespaces RetornoNamespace()
        {
            this.AdicionarValoresAoNamespace(string.Empty, string.Empty);
            return base.RetornoNamespace();
        }

        public override XmlAttributeOverrides CondicaoDeElementoXML()
        {
            this.IgnorarElemento("Quantidade", new ValidarXmlElemento<Pedido>(this).EIgualAString(x => x.Versao, "3.10"));
            return base.CondicaoDeElementoXML();
        }

    }
}
