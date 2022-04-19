using System;
using INSS.Calculadora.Abstracts;
using INSS.Calculadora.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTest
{
    [TestClass]
    public class TestCalculadorInss2012
    {
        [TestMethod]
        public void CalculaAbaixoFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 00.00M;
            decimal expected = 0.00M;

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaAcimaFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 4000.01M;
            decimal expected = 500.00M;

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaPrimeiaFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 1000.00M;
            decimal expected = (salario * 0.07M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaSegundaFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 1400.90M;
            decimal expected = (salario * 0.08M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaTerceiraFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 2500.90M;
            decimal expected = (salario * 0.09M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }


        [TestMethod]
        public void CalculaQuartaFaixaINSS_2012()
        {
            DateTime data = new DateTime(2012, 02, 15);
            decimal salario = 3500.90M;
            decimal expected = (salario * 0.11M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }
    }
}
