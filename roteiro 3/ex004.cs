using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"{
            'Servidor': 'localhost',
            'Porta': 3306,
            'Usuario': 'root'
        }";

        JObject configuracao = JObject.Parse(json);

        Console.WriteLine("Porta original: " + configuracao["Porta"]);

        configuracao["Porta"] = 5432;

        Console.WriteLine("Porta nova: " + configuracao["Porta"]);

        Console.WriteLine("\nJSON atualizado:");
        Console.WriteLine(configuracao.ToString());
    }
}
