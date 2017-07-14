using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository recetaRepository;

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void Guardar(Receta receta) 
        {
            recetaRepository.add(receta);

        }
        public Receta LeerReceta(String nombre)
        {
            return recetaRepository.read(nombre);
        }
        public IList<Receta> LeerLista()
        {
            return recetaRepository.read();
        }
        public void ActualizarLista()
        {
            recetaRepository.update(new Receta);
        }
        public void BorrarReceta(String nombre)
        {
            recetaRepository.delete(nombre);
        }
    }
}
