using Microsoft.AspNetCore.Mvc;

namespace MedicineManagement.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
