using GpsStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace GpsStation.Controllers
{
    public class DispositivoController : Controller
    {
        DispositivoModel dispositivo = new();
        public IActionResult Index()
        {
            return View(dispositivo);
        }

        public IActionResult Excluir()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Cadastro()
        {
            return View(dispositivo);
        }
    }
}
