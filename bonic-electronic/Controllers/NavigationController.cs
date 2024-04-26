using Microsoft.AspNetCore.Mvc;

namespace bonic_electronic.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult navigation()
        {
            return View();
        }
    }
}
