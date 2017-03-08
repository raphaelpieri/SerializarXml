using System;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    public abstract class XML<T> : ISeriliaziarObjetoParaXML
    {
        private readonly XmlAttributeOverrides _xmlAttributeOverrides;
        private readonly XmlSerializerNamespaces _xmlSerializerNamespaces;
        private readonly ValidarXmlElemento<T> _validarXmlElemento;
        public XML()
        {
            this._xmlAttributeOverrides = new XmlAttributeOverrides();
            this._xmlSerializerNamespaces = new XmlSerializerNamespaces();
        }
        protected void AdicionarValoresAoNamespace(string prefixo, string namespaces)
        {
            this._xmlSerializerNamespaces.Add("pedido", namespaces);
        }
        protected void IgnorarElemento(string nomeElemento, bool condicao)
        {
            var attr = new XmlAttributes();
            //attr.XmlIgnore = condicao;
            


            var a = new XmlAttributeAttribute("Teste");
            attr.XmlAttribute = a;
            this._xmlAttributeOverrides.Add(typeof(T), nomeElemento, attr);

        }

        public virtual XmlSerializerNamespaces RetornoNamespace()
        {
            return this._xmlSerializerNamespaces;
        }

        public virtual XmlAttributeOverrides CondicaoDeElementoXML()
        {
            return this._xmlAttributeOverrides;
        }
    }
}
