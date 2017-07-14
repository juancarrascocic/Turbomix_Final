using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    class ComprobadorDeIngredientesService
    {
        public bool ComprobarIngredientes(Alimento mAlimento1, Alimento mAlimento2, Receta mReceta)
        {
            if(mReceta.NombreAlimento1 != null && mReceta.NombreAlimento2 != null)
            {
                return mReceta.NombreAlimento1.Equals(mAlimento1.Nombre) && mReceta.NombreAlimento2.Equals(mAlimento2.Nombre);
            }

            return false;
        }
    }
}
