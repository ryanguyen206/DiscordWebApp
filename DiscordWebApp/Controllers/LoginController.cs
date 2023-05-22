using DiscordWebApp.Data;
using DiscordWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Composition.Convention;

namespace DiscordWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly DiscordContext _db;

        private Person personO { get; set; }

        public LoginUser MyProperty { get; set; }

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
      
  

            if (_db.Persons.Any(x => x.Email == person.Email && x.Password == person.Password))
            {
                personO = _db.Persons.Where(x => x.Email == person.Email && x.Password == person.Password).Single();
                return View(personO);

            } else
            {
                ModelState.AddModelError("Email", "Login or password is invalid");
                ModelState.AddModelError("Password", "Login or password is invalid");
                return View("Index");
            }
        
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentId = _db.Persons.Find(id);

            if (currentId == null)
            {
                return NotFound();
            }

            return View(currentId);
        }
    }
}
