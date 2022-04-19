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
    public class Cobrador : CobradorAbstract
    {
        public Cobrador()
        {
            this.ObtemImposto = new ObtemImposto();
            this.CalculaImposto = null;
        }

        public override decimal CalcularImposto(Desconto deconto, decimal salario)
        {
            throw new NotImplementedException();
        }

        public override Imposto ObterImposto(DateTime data, decimal salario)
        {
            return this.ObtemImposto.ObterImposto(data, salario);
        }
    }
}
