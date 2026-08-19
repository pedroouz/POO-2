using System.Xml.Serialization;

public class Program
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
    public static void Main() { 

        List<Produto> produtos = new List<Produto>();
        produtos.Add(new Produto { Nome = "Pão", Preco = 1.0 });
        produtos.Add(new Produto { Nome = "Espeto de frango", Preco = 10.00 });
        produtos.Add(new Produto { Nome = "Água", Preco = 2.00 });

        XmlSerializer serializer = new XmlSerializer(typeof(List<Produto>));

        using (StreamWriter writer = new StreamWriter("produtos.xml"))
        {
            serializer.Serialize(writer, produtos);
        }

        string conteudo = File.ReadAllText("produtos.xml");
        Console.WriteLine(conteudo);

    }

}

