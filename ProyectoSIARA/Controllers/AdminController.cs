using Microsoft.AspNetCore.Mvc;

namespace TuProyectoMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Asignaturas() => View();
        public IActionResult Graficas() => View();

        // LAS DOS NUEVAS RUTAS
        public IActionResult DocumentosIniciales() => View();
        public IActionResult DetalleDocente() => View();
    }
}