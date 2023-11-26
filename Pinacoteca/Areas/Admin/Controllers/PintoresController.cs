using Microsoft.AspNetCore.Mvc;
using Pinacoteca.Areas.Admin.Models;
using Pinacoteca.Models.Entities;

namespace Pinacoteca.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PintoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(AdminPintoresViewModel vmp)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(AdminPintoresViewModel vmp)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Eliminar(Pintor p)
        {
            return View();
        }
    }
}
