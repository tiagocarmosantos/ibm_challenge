using INSS.Cobrador.Abstracts;
using INSS.Cobrador.Implementations.Behaviors;
using INSS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Implementations
{
    public class CobradorFaixa : CobradorAbstract
    {
        public CobradorFaixa()
        {
            this.ObtemImposto = new ObtemImposto();
            this.CalculaImposto = new CalculaImpostoFaixa();
        }

        public override decimal CalcularImposto(Desconto desconto, decimal salario)
        {
            return this.CalculaImposto.CalcularImposto(desconto, salario);
        }

        public override Imposto ObterImposto(DateTime data, decimal salario)
        {
            return this.ObtemImposto.ObterImposto(data, salario);
        }
    }
}
