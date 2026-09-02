using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Produto
{
    [JsonProperty("Id", Order = 1)]
    public int Id { get; set; }

    [JsonProperty(
        "product_name",
        Order = 2,
        Required = Required.Always
    )]
    public string Nome { get; set; }

    [JsonProperty(
        "product_price",
        Order = 3,
        Required = Required.Always
    )]
    public double Preco { get; set; }

    [JsonProperty("Estoque", Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(
        "Fornecedor",
        Order = 5,
        NullValueHandling = NullValueHandling.Ignore
    )]
    public string Fornecedor { get; set; }

    [JsonIgnore]
    public string CodigoInterno { get; set; }
}

class Program
{
    static void Main()
    {

        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500,
                Estoque = 10,
                Fornecedor = "Dell",
                CodigoInterno = "NOTE-001"
            },

            new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 80,
                Estoque = 50,
                Fornecedor = null,
                CodigoInterno = "MOUSE-002"
            },

            new Produto
            {
                Id = 3,
                Nome = "Teclado",
                Preco = 150,
                Estoque = 30,
                Fornecedor = "Logitech",
                CodigoInterno = "TEC-003"
            }
        };

        string json = JsonConvert.SerializeObject(
            produtos,
            Formatting.Indented
        );

        File.WriteAllText("produtos.json", json);

        Console.WriteLine("JSON gravado com sucesso!\n");

        Console.WriteLine(json);

        string jsonArquivo = File.ReadAllText("produtos.json");

        List<Produto> produtosLidos =
            JsonConvert.DeserializeObject<List<Produto>>(jsonArquivo);

        Console.WriteLine("PRODUTOS DESSERIALIZADOS");


        foreach (Produto produto in produtosLidos)
        {
            Console.WriteLine($"Id: {produto.Id}");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
            Console.WriteLine($"Estoque: {produto.Estoque}");
            Console.WriteLine($"Fornecedor: {produto.Fornecedor}");
            Console.WriteLine("----------------------------");
        }

        Console.WriteLine("\n============================");
        Console.WriteLine("TESTE DE VALIDAÇÃO");
        Console.WriteLine("============================");

        string jsonInvalido = @"{
            ""Id"": 10,
            ""Estoque"": 5,
            ""Fornecedor"": ""Dell""
        }";

        try
        {
            Produto produtoInvalido =
                JsonConvert.DeserializeObject<Produto>(jsonInvalido);

            Console.WriteLine("Desserialização realizada!");
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("Erro: JSON inválido!");
            Console.WriteLine(ex.Message);
        }
    }
}
