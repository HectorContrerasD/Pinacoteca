using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Pinacoteca.Areas.Admin.Models;
using Pinacoteca.Models.Entities;
using Pinacoteca.Repositories;

namespace Pinacoteca.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CuadroController : Controller
    {
        private readonly CuadrosRepository cuadrosRepository;
        private readonly Repository<Coleccion> coleccionRepository;

        public CuadroController(CuadrosRepository cuadrosRepository,
            Repository<Coleccion> coleccionRepository)
        {
            this.cuadrosRepository = cuadrosRepository;
            this.coleccionRepository = coleccionRepository;
        }


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
        public IActionResult Agregar(AdminAgregarCuadrosViewModel vm)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(AdminAgregarCuadrosViewModel vm)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Eliminar(Cuadro c)
        {
            return View();
        }
    }
}
