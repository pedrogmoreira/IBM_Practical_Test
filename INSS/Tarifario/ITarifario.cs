using System.Collections.Generic;

namespace INSS.Tarifario
{
    public interface ITarifario
    {
        decimal GetDesconto(decimal salario);
    }
}