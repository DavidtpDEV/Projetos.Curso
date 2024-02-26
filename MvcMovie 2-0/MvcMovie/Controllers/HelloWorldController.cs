using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int numTimes = 1)
        {

            return HtmlEncoder.Default.Encode($"Ola {name}, sua visita: {numTimes}");
        }
    }
}
