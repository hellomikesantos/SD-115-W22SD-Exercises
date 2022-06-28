using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult Welcome(int? firstValue, int? secondvalue)
        {
            ViewBag.Grade = firstValue + secondvalue;
            ViewBag.IsCurrent = true;
            return View();
        }
    }
}
