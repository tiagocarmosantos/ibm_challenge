using INSS.Calculadora.Abstracts;
using INSS.Calculadora.Implementations;

namespace INSS.Calculadora.Factories
{
    public class CalculadoraFactory
    {
        public static CalculadoraAbstract ObterCalculadora()
        {
            CalculadoraAbstract calculadora = new CalculadoraInss();
            return calculadora;
        }
    }
}
