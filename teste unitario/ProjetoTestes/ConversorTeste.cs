using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTestes.ProjetoTestes
{
    public class ConversorTeste
    {
        public class ConversorTemperaturaTests
        {
            [Fact]
            public void CelsiusParaFahrenheit_Zero_DeveRetornar32()
            {
                var conversor = new ConversorTemperatura();

                double resultado = conversor.CelsiusParaFahrenheit(0);

                Assert.Equal(32, resultado, 2);
            }

            [Fact]
            public void CelsiusParaFahrenheit_Cem_DeveRetornar212()
            {
                var conversor = new ConversorTemperatura();

                double resultado = conversor.CelsiusParaFahrenheit(100);

                Assert.Equal(212, resultado, 2);
            }

            [Fact]
            public void FahrenheitParaCelsius_32_DeveRetornarZero()
            {
                var conversor = new ConversorTemperatura();

                double resultado = conversor.FahrenheitParaCelsius(32);

                Assert.Equal(0, resultado, 2);
            }

            [Fact]
            public void FahrenheitParaCelsius_212_DeveRetornar100()
            {
                var conversor = new ConversorTemperatura();

                double resultado = conversor.FahrenheitParaCelsius(212);

                Assert.Equal(100, resultado, 2);
            }
        }
    }
}
