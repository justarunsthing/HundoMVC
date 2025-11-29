using HundoMVC.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace HundoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult App()
        {
            var model = new Hundo
            {
                StartValue = 0,
                EndValue = 100
            };

            return View(model); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult App(Hundo model)
        {
            List<string> items = [];
            List<string> classes = [];

            for (int i = model.StartValue; i <= model.EndValue; i++)
            {
                items.Add(i.ToString());

                if (i % 2 == 0)
                {
                    classes.Add("bold");
                }
                else
                {
                    classes.Add("");
                }
            }

            model.Results = items;
            model.Classes = classes;

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}