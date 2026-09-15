using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {

        Console.Write("Digite o nome do Pokémon: ");
        string nome = Console.ReadLine()!.ToLower();

        string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string json = await client.GetStringAsync(url);

                dynamic pokemon = JsonConvert.DeserializeObject(json)!;

                Console.WriteLine("\nPokemon encontrado!");
                Console.WriteLine($"ID: {pokemon.id}");
                Console.WriteLine($"Nome: {pokemon.name}");
                Console.WriteLine($"Altura: {pokemon.height}");
                Console.WriteLine($"Peso: {pokemon.weight}");
                Console.WriteLine($"Base experience: {pokemon.base_experience}");

                Console.Write("Tipos: ");

                foreach (var tipo in pokemon.types)
                {
                    Console.Write($"{tipo.type.name} ");
                }

                Console.WriteLine();
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("\nPokémon não encontrado!");
            }
        }

    }
}