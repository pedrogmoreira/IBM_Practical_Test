using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.Tarifario
{
    internal class Tarifario2011 : TarifarioBase
    {
        public Tarifario2011()
            : base(new List<RangeSalario>()
                {
                    new RangeSalario(0, 1106.90M, 8.00M),
                    new RangeSalario(1106.91M, 1844.83M, 9.00M),
                    new RangeSalario(1844.84M, 3689.66M, 11.00M)
                }, 405.86M)
        {
        }
    }
}
