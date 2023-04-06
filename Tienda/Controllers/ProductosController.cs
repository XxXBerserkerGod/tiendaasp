using Microsoft.AspNetCore.Mvc;

namespace Tienda.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
