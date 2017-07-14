using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface IRecetaRepository
    {
        void add(Receta receta);
        void delete(string nombre);
        IList<Receta> read();
        Receta read(string name);
        void update(Receta receta);
    }
}