using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TestXmlConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var listap = new LoteDePedidos();
            Pedido p = new Pedido
            {
                ID = 1,
                Filial = "100",
                Numero = "50",
                Serie = "001",
                Itens = new List<Item>(),
                Quantidade = 41,
                Versao = "3.10"
                
            };

            p.Itens.Add(new Item()
            {
                Id = 1,
                Nome = "Feijao"
            });
            p.Itens.Add(new Item()
            {
                Id = 2,
                Nome = "Macarrao"
            });
            listap.Pedidos.Add(p);
            
            var s = FuncoesXML.TransformaEmXml<LoteDePedidos>(listap);
            System.Console.WriteLine(s);
            System.Console.ReadKey();

        }



    }
}
