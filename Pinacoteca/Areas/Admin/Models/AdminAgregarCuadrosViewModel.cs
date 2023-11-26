using Pinacoteca.Models.Entities;

namespace Pinacoteca.Areas.Admin.Models
{
    public class AdminAgregarCuadrosViewModel
    {
        public int IdColeccionSeleccionada { get; set; }
        public IEnumerable<ColeccionModel> Coleccion { get; set; } = null!;
        public IEnumerable<PintorModel> Pintor { get; set; } = null!;

        public Cuadro Cuadros { get; set; } = new();

        public IFormFile? Imagen { get; set; }

    }
    public class PintorModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;


    }
}
