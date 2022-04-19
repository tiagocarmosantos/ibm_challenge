using INSS.Calculadora.Implementations.Behaviors;
using INSS.Calculadora.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.Cobrador.Factories;
using INSS.Cobrador.Abstracts;

namespace INSS.Calculadora.Implementations
{
    public class CalculadoraInss : CalculadoraAbstract
    {
        public CalculadoraInss()
        {
            this.CobradorFactory = new CobradorFactory();
            this.CalculadorInss = new CalculadorInssPadrao(CobradorFactory);
        }

        public override decimal CalcularDesconto(DateTime data, decimal salario)
        {
            return this.CalculadorInss.CalcularDesconto(data, salario);
        }
    }
}
