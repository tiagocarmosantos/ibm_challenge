using INSS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Interfaces
{
    public interface IObtemImposto
    {
        /// <summary>
		/// Deve retornar o deconto do INSS.
		/// </summary>
		Imposto ObterImposto(DateTime data, decimal salario);
    }
}
