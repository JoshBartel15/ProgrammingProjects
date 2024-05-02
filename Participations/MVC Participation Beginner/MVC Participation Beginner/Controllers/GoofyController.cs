using Microsoft.AspNetCore.Mvc;

namespace MVC_Participation_Beginner.Controllers
{
    public class GoofyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
