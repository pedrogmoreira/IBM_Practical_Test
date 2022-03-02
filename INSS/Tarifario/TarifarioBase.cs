using System.Collections.Generic;
using System.Linq;

namespace INSS.Tarifario
{
    internal abstract class TarifarioBase : ITarifario
    {
        protected IList<RangeSalario> rangeContribuicao;
        protected decimal teto;

        public TarifarioBase(IList<RangeSalario> _rangeContribuicao, decimal _teto)
        {
            rangeContribuicao = _rangeContribuicao;
            teto = _teto;
        }

        public decimal GetDesconto(decimal salario)
        {
            var aliquota = GetAliquota(salario) / 100;
            return aliquota == default(decimal) ? teto : salario * aliquota;
        }

        public decimal GetAliquota(decimal salario)
        {
            return rangeContribuicao
                .Where(range => range.InRange(salario))
                .Select(x => x.GetAliquota())
                .SingleOrDefault();
        }
    }
}