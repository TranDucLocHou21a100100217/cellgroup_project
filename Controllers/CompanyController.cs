using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers
{
    public class CompanyController : Controller
    {
        // Action cho trang Giới thiệu
        public IActionResult About()
        {
            return View();
        }

        // Action cho trang Tuyển dụng
        public IActionResult Careers()
        {
            return View();
        }

        // Action cho trang Liên hệ
        public IActionResult Contact()
        {
            return View();
        }
    }
}
