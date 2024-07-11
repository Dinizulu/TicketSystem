using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
