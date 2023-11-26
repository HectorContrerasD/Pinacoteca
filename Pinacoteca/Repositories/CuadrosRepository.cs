using Microsoft.EntityFrameworkCore;
using Pinacoteca.Models.Entities;

namespace Pinacoteca.Repositories
{
    public class CuadrosRepository : Repository<Cuadro>
    {
        public CuadrosRepository(PinacotecabdContext context) : base(context)
        {
        }
        public override IEnumerable<Cuadro> GetAll()
        {
            return Context.Cuadro.Include(x => x.IdColeccionNavigation).OrderBy(x => x.TituloCuadro);
        }


        public IEnumerable<Cuadro> GetCuadroByColecion(int coleccion)
        {
            return Context.Cuadro.
                Include(x => x.IdColeccionNavigation)
                .Where(x => x.IdColeccion == coleccion).
                OrderBy(x => x.TituloCuadro);
        }
        public IEnumerable<Cuadro> GetCuadroByColeccion(string coleccion)
        {
            return Context.Cuadro.
                Include(x => x.IdColeccionNavigation)
                .Where(x => x.IdColeccionNavigation != null && x.IdColeccionNavigation.Nombre == coleccion).
                OrderBy(x => x.TituloCuadro);
        }

        public Cuadro? GetByNombre(string nombre)
        {
            return Context.Cuadro.Include(x => x.IdColeccionNavigation).FirstOrDefault(x => x.TituloCuadro == nombre);
        }
    }
}
