using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetarioService : IRecetarioService
    {
        public Plato CocinarReceta(Alimento mAlimento1, Alimento mAlimento2, Receta mReceta)
        {
            Plato PlatoReturn = null;
            ITermometro termometro = new Termometro();
            ComprobadorDeIngredientesService comprobadorDeIngredientes = new ComprobadorDeIngredientesService();
            ComprobadorDePesoService comprobadorDePesoService = new ComprobadorDePesoService();
            IBasculaService bascula = new BasculaService();
            ICocinaService cocina = new CocinaService();
            TurbomixService turbomix = new TurbomixService(bascula, cocina);

            // Comprobar que son los ingredientes correctos.
            if (comprobadorDeIngredientes.ComprobarIngredientes(mAlimento1, mAlimento2, mReceta))
            {
                if (!termometro.MedirTemperatura(mAlimento1) && !termometro.MedirTemperatura(mAlimento2))
                {
                    if (comprobadorDePesoService.ComprobarPeso(mAlimento1, mAlimento2, mReceta))
                    {
                        mAlimento1.Calentado = true;
                        mAlimento1.Peso = mReceta.PesoAlimento1;
                        mAlimento2.Peso = mReceta.PesoAlimento2;
                        mAlimento2.Calentado = true;
                        PlatoReturn = turbomix.PrepararPlato(mAlimento1, mAlimento2);
                    }
                }
            }
            return PlatoReturn;
        }
    }
}
