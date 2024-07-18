using Microsoft.AspNetCore.Mvc;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }
        [HttpGet]
        public IActionResult Details()
        {
            var lstUsers = _context.users.ToList();
                return View(lstUsers);
        }
    }
}
