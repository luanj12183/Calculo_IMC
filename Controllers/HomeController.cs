using Microsoft.AspNetCore.Mvc;
using Calculo_IMC.Models;

namespace Calculo_IMC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
        return View(new ImcViewModel());
        }

        [HttpPost]
        public IActionResult Index(ImcViewModel model)
        {
            if (ModelState.IsValid) 
            {
                model.ResultadoImc = model.Peso / (model.Altura * model.Altura);
            
                if (model.ResultadoImc < 18.5)
            {
                model.Classificacao = "Abaixo do peso";
                model.ClasseCss = "alert-warning";
            }

            else if (model.ResultadoImc < 25) 
            {
                model.Classificacao = "Peso normal";
                model.ClasseCss = "alert-success";
            }

            else if (model.ResultadoImc <30) 
            {
                model.Classificacao = "Sobrepeso";
                model.ClasseCss = "alert-warning"; 
            }

            else 
            {
                model.Classificacao = "Obesidade";
                model.ClasseCss = "alert-danger";
            }
            return View(model);
        }
            return View(model);
        }
    }
}           