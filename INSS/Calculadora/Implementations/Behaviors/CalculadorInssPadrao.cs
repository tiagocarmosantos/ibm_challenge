using INSS.Calculadora.Interfaces.INSS;
using INSS.Cobrador.Abstracts;
using INSS.Shared;
using INSS.Shared.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Calculadora.Implementations.Behaviors
{
    public class CalculadorInssPadrao : ICalculadorInss
    {
        private CobradorAbstractFactory CobradorFactory { get; set; }

        public CalculadorInssPadrao(CobradorAbstractFactory CobradorFactory)
        {
            this.CobradorFactory = CobradorFactory;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            Imposto imposto = this.CobradorFactory.ObterCobrador().ObterImposto(data, salario);
            return this.CobradorFactory.ObterCobrador(imposto.Desconto.Tipo).CalcularImposto(imposto.Desconto, salario);
        }
    }
}
