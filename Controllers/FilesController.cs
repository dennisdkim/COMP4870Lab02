
using Microsoft.AspNetCore.Mvc;

namespace mvctextfiles.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
         string[] files = Directory.GetFiles("TextFiles").Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
         return View(files);
        }

        public IActionResult Content(string id)
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "/TextFiles/" + id + ".txt");
            return View(lines);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}