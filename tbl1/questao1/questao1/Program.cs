
class Produto
{
    public string nome {  get; set; }
    public decimal valor { get; set; }
    public int quantidade { get; set; }

    public decimal ValorTotalCalculado()
    {
        return quantidade * valor;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Inicio do sistema - Empresa Tal \nMenu:\n1. Adicionar pedido\n2. Sair");
        int menu = int.Parse(Console.ReadLine());

        while (menu != 2) {
            if (menu == 1)
            {
                
                List<Produto> produtos = new List<Produto>();
                Console.WriteLine("Insira o nome do cliente:");
                string nome_cliente = Console.ReadLine();
                string escolha = "s";

                while(escolha == "s")
                {
                    Produto produto = new Produto();

                    Console.WriteLine("Nome do produto: ");
                    produto.nome = Console.ReadLine();

                    Console.WriteLine("Valor: ");
                    produto.valor = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade: ");
                    produto.quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Adicionar mais produtos? (s/n)");
                    escolha = Console.ReadLine();

                    produtos.Add(produto);
                }

                Console.Write("Informe a forma de pagamento: ");
                string formaPagamento = Console.ReadLine();

                decimal valorTotal = 0;
                foreach (var p in produtos)
                {
                    valorTotal += p.ValorTotalCalculado();
                }
                Console.Clear();
                Console.WriteLine("=== RESUMO DO PEDIDO ===");
                Console.WriteLine($"Cliente: {nome_cliente}");
                Console.WriteLine("Itens:");
                foreach (var p in produtos)
                {
                    Console.WriteLine($"{p.quantidade} {p.nome} (R$ {p.valor:F2}) = R$ {p.ValorTotalCalculado():F2}");
                }
                Console.WriteLine($"Valor Total: R$ {valorTotal:F2}");
                Console.WriteLine($"Forma de Pagamento: {formaPagamento}");

            }
        }
        
    }
}

