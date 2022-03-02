using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Tarifario
{
    internal class RangeSalario
    {

        private decimal SalarioMinimo;
        private decimal SalarioMaximo;
        private decimal Aliquota;

        public RangeSalario(decimal salarioMinimo, decimal salarioMaximo, decimal aliquota)
        {
            SalarioMinimo = salarioMinimo;
            SalarioMaximo = salarioMaximo;
            Aliquota = aliquota;
        }

        public decimal GetAliquota()
        {
            return Aliquota;
        }

        public bool InRange(decimal salario)
        {
            return salario >= SalarioMinimo && salario <= SalarioMaximo;
        }
    }
}
