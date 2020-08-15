using Microsoft.AspNetCore.Mvc;
using TestRazorCompile.Models;

namespace TestRazorCompile.Controllers
{

    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("{a}/{b}")]
        public IActionResult Index(int a = 1, int b = 1, string path = "Default")
        {
            var model = new ViewModel { A = a, B = b };
            return View($"Themes/{path}/View.cshtml", model);
        }
    }
}
