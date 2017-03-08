using System.IO;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    public static class FuncoesXML
    {
        public static string TransformaEmXml<T>(this T objeto) where T : ISeriliaziarObjetoParaXML
        {
            var s = new XmlSerializer(objeto.GetType(), objeto.CondicaoDeElementoXML());

            using (var xml = new StringWriter())
            {
                s.Serialize(xml, objeto, objeto.RetornoNamespace());
                return xml.ToString();
            }

        }
    }
}
