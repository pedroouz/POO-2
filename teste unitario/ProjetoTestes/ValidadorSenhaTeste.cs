using System;
using System.Collections.Generic;
using System.Text;
using static ProjetoTestes.Projeto.ValidadorSenha;

namespace ProjetoTestes.ProjetoTestes
{
    public class ValidadorSenhaTeste
    {
        [Fact]
        public void Senha123_DeveSerValida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("Senha123");

            Assert.True(resultado);
        }

        [Fact]
        public void SenhaApenasNumeros_DeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("12345678");

            Assert.False(resultado);
        }

        [Fact]
        public void SenhaVazia_DeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("");

            Assert.False(resultado);
        }

        [Fact]
        public void SenhaApenasLetras_DeveSerInvalida()
        {
            var validador = new ValidadorSenha();

            bool resultado = validador.EhValida("abcdEFGH");

            Assert.False(resultado);
        }
    }
}
