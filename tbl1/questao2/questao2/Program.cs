
class Carrinho
{
    List<Produto> produtos = new List<Produto>();
    public string Forma_de_Pagamento {  get; set; }

    public void DefinirFormadePagamento(string forma)
    {
        Forma_de_Pagamento = forma;
    }
    public void AdicionarProduto(Produto p)
    {
        produtos.Add(p);
    }

    public void RemoverProduto(int id)
    {
        produtos.RemoveAll(produto => produto.Codigo == id);
    }
    public void VerCarrinho()
    {
        Console.WriteLine("Carrinho: ");
        foreach(Produto produto in produtos)
        {
            Console.WriteLine($"Produto{produto.Codigo}: - {produto.Nome} - Valor: {produto.Valor} - Quantidade: {produto.Quantidade}\n");
            Console.WriteLine($"Forma de pagamento: {Forma_de_Pagamento}");
            Console.WriteLine(CalcularValorTotal());
        }
    }

    public decimal CalcularValorTotal()
    {
        decimal valor_total = 0;
        foreach(Produto produto in produtos)
        {
            decimal valor_produto = produto.Valor * produto.Quantidade;
            valor_total += valor_produto;
        }
        return valor_total;
    }
}

class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public int Quantidade { get; set; }

    public Produto (int codigo, string nome, decimal valor, int quantidade)
    {
        Codigo = codigo;
        Nome = nome;
        Valor = valor;
        Quantidade = quantidade;
    }
}

class Program
{
    static void Main()
    {
        Carrinho carrinho = new Carrinho();
        Produto p1 = new Produto(1, "Blusinha da shein", 57, 3);
        Produto p2 = new Produto(2, "calça da shein", 123, 1);
        carrinho.DefinirFormadePagamento("Boleto");
        carrinho.AdicionarProduto(p1);
        carrinho.AdicionarProduto(p2);
        carrinho.VerCarrinho();
        carrinho.RemoverProduto(2);
        carrinho.VerCarrinho();
    }
}