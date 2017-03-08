using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    [XmlType(TypeName = "loteDePedido")]
    public class LoteDePedidos : XML<LoteDePedidos>
    {
        [XmlArray("pedidos")]
        public List<Pedido> Pedidos { get; set; }

        public LoteDePedidos()
        {
            this.Pedidos = new List<Pedido>();
        }
        public override XmlSerializerNamespaces RetornoNamespace()
        {
            return base.RetornoNamespace();
        }
    }
}
