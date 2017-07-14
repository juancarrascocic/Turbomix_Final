using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Receta
    {
        public String NombreAlimento1 { get; set; }
        public String NombreAlimento2 { get; set; }
        public float PesoAlimento1 { get; set; } = 0;
        public float PesoAlimento2 { get; set; } = 0;

        public Receta(String NombreAlimento1, String NombreAlimento2,
            float PesoAlimento1,float PesoAlimento2)
        {
            this.NombreAlimento1 = NombreAlimento1;
            this.NombreAlimento2 = NombreAlimento2;
            this.PesoAlimento1 = PesoAlimento1;
            this.PesoAlimento2 = PesoAlimento2;
        }
        public Receta() { }

    }
}
