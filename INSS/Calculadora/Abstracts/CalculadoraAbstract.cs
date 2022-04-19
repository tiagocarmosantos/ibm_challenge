using System;
using INSS.Calculadora.Interfaces.INSS;
using INSS.Cobrador.Abstracts;

namespace INSS.Calculadora.Abstracts
{
    public abstract class CalculadoraAbstract
    {
        #region Properties

            protected ICalculadorInss CalculadorInss { get; set; }
            protected CobradorAbstractFactory CobradorFactory { get; set; }

        #endregion Properties

        #region Methods

            public abstract decimal CalcularDesconto(DateTime data, decimal salario);

        #endregion Methods
    }
}
