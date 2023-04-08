using GpsStation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GpsStation.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar(Guid id)
        {
            UsuarioModel usuario1 = new UsuarioModel();
            ViewBag.usuario = usuario1;
            return View();
        }

        [HttpPost]
        public IActionResult Gravar(UsuarioModel usuario)
        {
            ViewBag.usuario = usuario;
            return RedirectToAction("Editar");
        }
    }
}
