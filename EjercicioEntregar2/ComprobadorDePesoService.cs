using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    class ComprobadorDePesoService
    {
        public bool ComprobarPeso(Alimento mAlimento1, Alimento mAlimento2, Receta mReceta)
        {
            return mReceta.PesoAlimento1 <= mAlimento1.Peso && mReceta.PesoAlimento2 <= mAlimento2.Peso;
        }
    }
}
