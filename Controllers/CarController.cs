using Fiap.Web.AspNet3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detales()
        {
            var carModel = new CarModel
            {
                CarrroId = 1,
                MarcaCarro = "Vw",
                NomeCarro = "UP TSI",
                ModeloCarro = "Pepper",
                AnoCarro = 2020,
                KmCarro = 35000,
                FotoCarro = ""

            };

            return View(carModel);
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(CarModel carModel)
        {

            if (ModelState.IsValid)
            {
                TempData["mensagem"] = "Carro Cadastrado com Sucesso! ";
                return RedirectToAction("Index");
            }
            else
            {
                return View(carModel);
            }

        }

        public IActionResult Edit()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Edit(CarModel carModel)
        {
            if (ModelState.IsValid)
            {
                TempData["mensagem"] = "Carro alterado com Sucesso!";
                return RedirectToAction("Index");


            }
            else
            {
                return View(carModel);
            }

        }





    }
}
