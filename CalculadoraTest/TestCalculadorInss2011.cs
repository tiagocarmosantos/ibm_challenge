using System;
using INSS.Calculadora.Abstracts;
using INSS.Calculadora.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTest
{
    [TestClass]
    public class TestCalculadorInss2011
    {
        [TestMethod]
        public void CalculaAbaixoFaixaINSS_2011()
        {
            DateTime data = new DateTime(2011, 02, 15);
            decimal salario = 00.00M;
            decimal expected = 0.00M;

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaAcimaFaixaINSS_2011()
        {
            DateTime data = new DateTime(2011, 02, 15);
            decimal salario = 3689.67M;
            decimal expected = 405.86M;

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaPrimeiaFaixaINSS_2011()
        {
            DateTime data = new DateTime(2011, 02, 15);
            decimal salario = 1106.90M;
            decimal expected = (salario * 0.08M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);
                        
            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaSegundaFaixaINSS_2011()
        {
            DateTime data = new DateTime(2011, 02, 15);
            decimal salario = 1800.90M;
            decimal expected = (salario * 0.09M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }

        [TestMethod]
        public void CalculaTerceiraFaixaINSS_2011()
        {
            DateTime data = new DateTime(2011, 02, 15);
            decimal salario = 2500.90M;
            decimal expected = (salario * 0.11M);

            CalculadoraAbstract CalculadoraInss = CalculadoraFactory.ObterCalculadora();
            decimal descontoINSS = CalculadoraInss.CalcularDesconto(data, salario);

            Assert.AreEqual(expected, descontoINSS);
        }
    }
}
