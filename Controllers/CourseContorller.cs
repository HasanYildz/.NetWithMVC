using DotNetAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            return View();
        }
    }


}