using INSS.Shared.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Shared
{
    public class Imposto
    {
        public string Ano { get; set; }

        public decimal SalarioInicial { get; set; }

        public decimal SalarioFinal { get; set; }

        public Desconto Desconto { get; set; }

        public TipoImposto TipoImposto { get; set; }

        public Imposto()
        {
            this.Ano = string.Empty;
            this.SalarioInicial = 00.00M;
            this.SalarioFinal = 00.00M;
            this.Desconto = new Desconto();
            this.TipoImposto = TipoImposto.Aliquota;
        }
    }
}
