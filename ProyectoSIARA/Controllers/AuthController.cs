using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class AuthController : Controller
    {
        // Pantalla 1
        public IActionResult Login() => View();

        // Pantalla 2
        public IActionResult Recuperar() => View();

        // Pantalla 3
        public IActionResult Restablecer() => View();
    }
}