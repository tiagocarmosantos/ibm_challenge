using INSS.Shared.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Shared
{
    public class Desconto
    {
        public TipoDesconto Tipo { get; set; }
        public decimal Valor { get; set; }

        public Desconto()
        {
            this.Tipo = TipoDesconto.Faixa;
            this.Valor = 00.00M;
        }
    }
}
