using INSS.Cobrador.Interfaces;
using INSS.Shared;
using INSS.Shared.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Abstracts
{
    public abstract class CobradorAbstractFactory
    {
        #region Methods

            public abstract CobradorAbstract ObterCobrador();
            public abstract CobradorAbstract ObterCobrador(TipoDesconto tipoDesconto);

        #endregion Methods
    }
}
