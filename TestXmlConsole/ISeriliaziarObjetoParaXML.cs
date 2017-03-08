using System.Xml.Serialization;

namespace TestXmlConsole
{
    public interface ISeriliaziarObjetoParaXML
    {
        XmlSerializerNamespaces RetornoNamespace();
        XmlAttributeOverrides CondicaoDeElementoXML();
    }
}
