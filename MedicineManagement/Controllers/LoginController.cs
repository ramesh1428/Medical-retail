using Microsoft.AspNetCore.Mvc;

namespace MedicineManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
