using INSS.Tarifario;
using System;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            ITarifario tarifario = TarifarioFactory.GetTarifario(data.Year);
            return tarifario.GetDesconto(salario);
        }
    }
}
