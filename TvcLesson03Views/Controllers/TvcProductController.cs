using Microsoft.AspNetCore.Mvc;

namespace TvcLesson03Views.Controllers
{
    public class TvcProductController : Controller
    {
        public IActionResult Index(int? pid)
        {
            ViewBag.pid = pid;
            return View();
        }
    }
}
