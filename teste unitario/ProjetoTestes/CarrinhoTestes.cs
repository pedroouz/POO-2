using ProjetoTestes.Projeto;
using Xunit;

namespace AulaTestes.Tests
{
    public class CarrinhoTests
    {
        [Fact]
        public void AdicionarItens_DeveSomarCorretamenteOTotal()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Produto 1",
                Preco = 10.00
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Produto 2",
                Preco = 20.00
            });

            double total = carrinho.Total();

            Assert.Equal(30.00, total);
        }

        [Fact]
        public void Limpar_DeveZerarOCarrinho()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Produto",
                Preco = 50.00
            });

            carrinho.Limpar();

            Assert.Equal(0, carrinho.Total());
            Assert.Equal(0, carrinho.Quantidade());
        }

        [Fact]
        public void Quantidade_DeveRetornarNumeroCorretoDeItens()
        {
            var carrinho = new Carrinho();

            carrinho.Adicionar(new Item
            {
                Nome = "Produto 1",
                Preco = 10
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Produto 2",
                Preco = 20
            });

            carrinho.Adicionar(new Item
            {
                Nome = "Produto 3",
                Preco = 30
            });

            Assert.Equal(3, carrinho.Quantidade());
        }
    }
}
