using INSS.Cobrador.Interfaces;
using INSS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Implementations.Behaviors
{
    public class CalculaImpostoTeto : ICalculaImposto
    {
        public decimal CalcularImposto(Desconto desconto, decimal salario)
        {
            return desconto.Valor;
        }
    }
}
