using INSS.Cobrador.Abstracts;
using INSS.Cobrador.Implementations;
using INSS.Shared.Enumerators;

namespace INSS.Cobrador.Factories
{
    public class CobradorFactory : CobradorAbstractFactory
    {
        public override CobradorAbstract ObterCobrador()
        {
            CobradorAbstract cobrador = new Implementations.Cobrador();
            return cobrador;
        }

        public override CobradorAbstract ObterCobrador(TipoDesconto tipoDesconto)
        {
            CobradorAbstract cobrador = new Implementations.Cobrador();
            switch (tipoDesconto)
            {
                case TipoDesconto.Faixa:
                    cobrador = new Implementations.CobradorFaixa();
                    break;
                case TipoDesconto.Teto:
                    cobrador = new Implementations.CobradorTeto();
                    break;
            }
            return cobrador;
        }
    }
}
