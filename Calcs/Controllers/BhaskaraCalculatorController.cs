using Microsoft.AspNetCore.Mvc;
using Calcs.Models;

namespace Calcs.Controllers
{
    public class BhaskaraCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculateBhaskaraViewModel data)
        {
            double delta = Math.Pow(data.ValueB, 2) - (4 * data.ValueA * data.ValueC);

            data.X1 = -data.ValueB + Math.Sqrt(delta) / (2 * data.ValueA);
            data.X2 = -data.ValueB - Math.Sqrt(delta) / (2 * data.ValueA);

            return View(data);
        }
    }
}
