using Calcs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calcs.Controllers
{
    public class CalculatorController : Controller
    {
        //método Get que irá nos retornar uma view
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //método post que irá nos retornar o resultado da operação
        [HttpPost]
        public IActionResult Index(CalculateViewModel calculateViewModel)
        {
            ModelState.Clear();
            if ("+".Equals(calculateViewModel.Operator))
            {
                calculateViewModel.Result = calculateViewModel.ValueA + calculateViewModel.ValueB;
            }
            else if ("-".Equals(calculateViewModel.Operator))
            {
                calculateViewModel.Result = calculateViewModel.ValueA - calculateViewModel.ValueB;

            }
            else if ("*".Equals(calculateViewModel.Operator))
            {
                calculateViewModel.Result = calculateViewModel.ValueA * calculateViewModel.ValueB;
            }
            else if ("/".Equals(calculateViewModel.Operator))
            {
                calculateViewModel.Result = calculateViewModel.ValueA / calculateViewModel.ValueB;
            }
            else
            {
                throw new Exception("operador inválido");
            }



            return View(calculateViewModel);
        }
    }
}
