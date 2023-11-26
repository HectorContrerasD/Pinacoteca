using Pinacoteca.Models.Entities;

namespace Pinacoteca.Areas.Admin.Models
{
    public class AdminPintoresViewModel
    {
    
        public Pintor Pintores { get; set; } = new();
        public IFormFile? Archivo { get; set; }
    }
}
