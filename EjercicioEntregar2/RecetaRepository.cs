using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        private static IList<Receta> repositorio = new List<Receta>();

        public void add(Receta receta)
        {
            repositorio.Add(receta);
        }
        public IList<Receta> read()
        {
            return repositorio;
        }
        public Receta read(String name)
        {
            return new Receta();
        }
        public void update(Receta receta)
        {
            return;
        }
        public void delete(String nombre)
        {
            return;
        }
    }
}
