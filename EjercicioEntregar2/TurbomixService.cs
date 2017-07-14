using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class TurbomixService
    {
        public IBasculaService basculaService { get; set; }
        public ICocinaService cocinaService { get; set; }

        public TurbomixService(IBasculaService _Bascula, ICocinaService _Cocina)
        {
            this.basculaService = _Bascula;
            this.cocinaService = _Cocina;
        }

        public Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2)
        {
            float Peso1 = basculaService.Pesar(mAlimento1);
            float Peso2 = basculaService.Pesar(mAlimento2);
            cocinaService.Calentar(mAlimento1, mAlimento2);

            return new Plato(mAlimento1, mAlimento2);
        }

    }
}
