using DiscordWebApp.Data;
using DiscordWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiscordWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly DiscordContext _db;

        public LoginController(DiscordContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(LoginUser person)
        {
            if (person.Email == null && person.Password == null)
            {
                return NotFound();
            } 

            bool userExists = _db.Persons.Any(x => x.Email== person.Email && x.Password ==  person.Password);

            if (userExists)
            {
                return RedirectToAction("Index", "LoggedIn", person);
            } else
            {
                return NotFound();
            }




            return View("Index");


        }
    }
}
