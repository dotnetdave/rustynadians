using Microsoft.AspNetCore.Mvc;

namespace helloskylinerapp
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View(); // Index.cshtml
    }
}
