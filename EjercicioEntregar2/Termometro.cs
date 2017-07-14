using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Termometro : ITermometro
    {
        public bool MedirTemperatura(Alimento mAlimento)
        {
            return mAlimento.Calentado;
        }
    }
}
