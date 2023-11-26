namespace Pinacoteca.Areas.Admin.Models
{
    public class AdminColeccionViewModel
    {
        public IEnumerable<ColeccionModel> Coleccion { get; set; } = null!;

    }
    public class ColeccionModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

    }
}
