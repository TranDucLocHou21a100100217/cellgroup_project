using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers
{
    public class PharmacistController : Controller
    {

        public IActionResult Pharmacist()
        {
            return View();
        }
    }
}