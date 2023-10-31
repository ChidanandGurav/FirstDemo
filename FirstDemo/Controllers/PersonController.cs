using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace FirstDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> Cities = new List<string>()
            {
                "Pune" , "Mumbai" , "Nashik" , "Bemgalore" , "Belgaum"
            };

            ViewData["Cities"] = new SelectList(Cities);
            return View();
        }

        [HttpPost]

        public IActionResult PersonalDetails(IFormCollection form , ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["Cities"];
            ViewBag.Hobbies = hobbies;
            return View("DisplayDetails");
        }

    }
}
