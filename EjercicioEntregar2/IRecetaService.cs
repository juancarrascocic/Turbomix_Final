using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface IRecetaService
    {
        void ActualizarLista();
        void BorrarReceta(string nombre);
        void Guardar(Receta receta);
        IList<Receta> LeerLista();
        Receta LeerReceta(string nombre);
    }
}