using DiscordWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiscordWebApp.Controllers
{
    public class LoggedIn : Controller
    {
        public IActionResult Index(LoginUser person)
        {
            return View(person);
        }
    }
}
