using Microsoft.AspNetCore.Mvc;

namespace Tienda.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
