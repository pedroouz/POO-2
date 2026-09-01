
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Livro livro = new Livro("A Paciente Silenciosa", "R.J Michaels", 2024);
        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);
    }
}

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano {  get; set; }

    public Livro (string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

}
