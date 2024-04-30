using Microsoft.AspNetCore.Mvc;

namespace bonic_electronic.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult landingpage()
        {
            return View();
        }
    }
}
