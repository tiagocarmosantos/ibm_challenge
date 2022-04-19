using INSS.Cobrador.Interfaces;
using INSS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Abstracts
{
    public abstract class CobradorAbstract
    {
        #region Properties
           
            protected IObtemImposto ObtemImposto { get; set; }
            protected ICalculaImposto CalculaImposto { get; set; }

        #endregion Properties

        #region Methods

            public abstract Imposto ObterImposto(DateTime data, decimal salario);
            public abstract decimal CalcularImposto(Desconto desconto, decimal salario);

        #endregion Methods
    }
}
