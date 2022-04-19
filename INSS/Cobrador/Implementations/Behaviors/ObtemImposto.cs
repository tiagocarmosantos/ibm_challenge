using INSS.Cobrador.Interfaces;
using INSS.Shared;
using INSS.Shared.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Cobrador.Implementations.Behaviors
{
    public class ObtemImposto : IObtemImposto
    {
        private List<Imposto> Aliquotas { get; set; }

        public ObtemImposto()
        {
            this.Aliquotas = new List<Imposto>();

            this.Aliquotas.Add(new Imposto() { Ano = "2011", SalarioFinal = 1106.90M, Desconto = { Valor = 0.08M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2011", SalarioInicial = 1106.91M, SalarioFinal = 1844.83M, Desconto = { Valor = 0.09M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2011", SalarioInicial = 1844.84M, SalarioFinal = 3689.66M, Desconto = { Valor = 0.11M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2011", SalarioInicial = 3689.67M, Desconto = { Valor = 405.86M, Tipo = TipoDesconto.Teto } });

            this.Aliquotas.Add(new Imposto() { Ano = "2012", SalarioFinal = 1000.00M, Desconto = { Valor = 0.07M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2012", SalarioInicial = 1000.01M, SalarioFinal = 1500.00M, Desconto = { Valor = 0.08M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2012", SalarioInicial = 1500.01M, SalarioFinal = 3000.00M, Desconto = { Valor = 0.09M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2012", SalarioInicial = 3000.01M, SalarioFinal = 4000.00M, Desconto = { Valor = 0.11M } });
            this.Aliquotas.Add(new Imposto() { Ano = "2012", SalarioInicial = 4000.01M, Desconto = { Valor = 500.00M, Tipo = TipoDesconto.Teto } });
        }

        public Imposto ObterImposto(DateTime data, decimal salario)
        {
            string ano = data.ToString("yyyy");

            Imposto imposto = this.Aliquotas.Where(i => i.Ano == ano && (salario >= i.SalarioInicial && salario <= i.SalarioFinal)).FirstOrDefault();
            imposto = (imposto == null ? this.Aliquotas.Where(i => i.Ano == ano && i.Desconto.Tipo == TipoDesconto.Teto).FirstOrDefault() : imposto);

            return imposto;
        }
    }
}
