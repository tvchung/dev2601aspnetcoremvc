using Microsoft.AspNetCore.Mvc;

namespace TvcLesson03Views.Controllers
{
    public class TvcRazorCodeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
