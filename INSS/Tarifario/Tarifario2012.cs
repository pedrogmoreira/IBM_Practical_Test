using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Tarifario
{
    internal class Tarifario2012 : TarifarioBase
    {
        public Tarifario2012()
            : base(new List<RangeSalario>()
                {
                    new RangeSalario(0.00M, 1000.00M, 7.00M),
                    new RangeSalario(1000.01M, 1500.00M, 8.00M),
                    new RangeSalario(1500.01M, 3000.00M, 9.00M),
                    new RangeSalario(3000.01M, 4000.00M, 11.00M)
                }, 500.00M)
        {
        }
    }
}
