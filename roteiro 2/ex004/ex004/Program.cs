using System;
using System.Net.Http;
using System.Xml;

class Program
{
    static async Task Main()
    {
        string url = "https://www.w3schools.com/xml/simple.xml";

        using (HttpClient client = new HttpClient())
        {

            string response = await client.GetStringAsync(url);

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(response);

            XmlNodeList alimentos = doc.SelectNodes("//food");

            foreach (XmlNode food in alimentos)
            {
                string nome = food.SelectSingleNode("name").InnerText;
                string preco = food.SelectSingleNode("price").InnerText;

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Preço: " + preco);
            }
        }
    }
}