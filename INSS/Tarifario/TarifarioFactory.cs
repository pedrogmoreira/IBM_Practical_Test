using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Tarifario
{
    public class TarifarioFactory
    {
        public static ITarifario GetTarifario(int ano)
        {
            string tarifarioClassName = "INSS.Tarifario.Tarifario" + ano;
            Type type = Type.GetType(tarifarioClassName, true);
            ITarifario newInstance = (ITarifario)Activator.CreateInstance(type);
            return newInstance;
        }        
    }
}
