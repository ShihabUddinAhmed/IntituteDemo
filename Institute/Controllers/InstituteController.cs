using Microsoft.AspNetCore.Mvc;

namespace Institute.Controllers
{
    public class InstituteController : Controller
    {
        public IActionResult StudentList()
        {
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }
    }
}
