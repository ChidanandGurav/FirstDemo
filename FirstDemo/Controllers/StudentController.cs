using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]

        public IActionResult StudentDetails()
        {
            List<string> Cities = new List<string>()
            {
                "Pune" , "Mumbai" , "Nashik" , "Bemgalore" , "Belgaum"
            };

            ViewData["Cities"] = new SelectList(Cities);
            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form, ICollection<string> Subject)
        {
            ViewBag.RollNo = form["Roll No"];
            ViewBag.Name = form["Name"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["Cities"];
            ViewBag.Subject = Subject;
            return View("DisplayStudDetails");
        }
    }
}
