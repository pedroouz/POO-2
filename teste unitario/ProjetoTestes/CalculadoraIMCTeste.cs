using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTestes.Projeto;

namespace ProjetoTestes.ProjetoTestes
{
    public class CalculadoraIMCTeste
    {
        public class CalculadoraIMCTests
        {
            [Fact]
            public void Calcular_70kg_175m_DeveRetornarAproximadamente2286()
            {
                var calculadora = new CalculadoraIMC();

                double resultado = calculadora.Calcular(70, 1.75);

                Assert.Equal(22.86, resultado, 2);
            }

            [Fact]
            public void Classificar_17_DeveRetornarAbaixoDoPeso()
            {
                var calculadora = new CalculadoraIMC();

                string resultado = calculadora.Classificar(17);

                Assert.Equal("Abaixo do peso", resultado);
            }

            [Fact]
            public void Classificar_26_DeveRetornarSobrepeso()
            {
                var calculadora = new CalculadoraIMC();

                string resultado = calculadora.Classificar(26);

                Assert.Equal("Sobrepeso", resultado);
            }

            [Fact]
            public void Calcular_AlturaZero_DeveLancarArgumentException()
            {
                var calculadora = new CalculadoraIMC();

                Assert.Throws<ArgumentException>(() =>
                    calculadora.Calcular(70, 0)
                );
            }
        }
    }
}
