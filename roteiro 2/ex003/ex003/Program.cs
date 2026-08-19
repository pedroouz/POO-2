using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument documento = XDocument.Load("estoque.xml");

        foreach (XElement item in documento.Root.Elements("item"))
        {
            XElement nome = item.Element("nome");

            if (nome != null && nome.Value == "Mouse")
            {
                item.Element("quantidade").Value = "10";

                Console.WriteLine("Quantidade atualizada");
            }
        }

        documento.Save("estoque.xml");

    }
}
