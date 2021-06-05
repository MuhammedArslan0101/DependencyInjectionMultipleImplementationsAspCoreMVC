using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMultipleImplementationsCore.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
