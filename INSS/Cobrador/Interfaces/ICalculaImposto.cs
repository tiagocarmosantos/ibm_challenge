using INSS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Interfaces
{
    public interface ICalculaImposto
    {
        /// <summary>
		/// Deve calcular o deconto do INSS.
		/// </summary>
		decimal CalcularImposto(Desconto desconto, decimal salario);
    }
}
