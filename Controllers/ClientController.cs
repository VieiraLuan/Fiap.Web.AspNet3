using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class ClientController : Controller
    {

        private readonly ClienteRepository clienteRepository;
        private readonly RepresentanteRepository representanteRepository;

        public ClientController(DataContext dataContext)
        {
            clienteRepository = new ClienteRepository(dataContext);
            representanteRepository = new RepresentanteRepository(dataContext);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaClientes = clienteRepository.FindAll();

            return View(listaClientes);
        }


        public IActionResult NewClient()
        {
            var listaRepresentantes = representanteRepository.FindAll();
            ViewBag.representantes = listaRepresentantes;

            return View(new ClientModel());
        }

        [HttpPost]
        public IActionResult NewClient(ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                clienteRepository.Insert(clientModel);
                TempData["mensagem"] = "Cliente cadastrado com sucesso";/*Retorna Mensagem de Sucesso na View*/

                return RedirectToAction("Index");
            }
            else
            {
                var listaRepresentantes = representanteRepository.FindAll();
                ViewBag.representantes = listaRepresentantes;

                return View(clientModel);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cliente = clienteRepository.FindById(id);
            var listaRepresentantes = representanteRepository.FindAll();
            ViewBag.representantes = listaRepresentantes;


            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(ClientModel clientModel)/*Passar por parametro a classe e um objeto para carregar*/
        {

            if (ModelState.IsValid)
            {
                clienteRepository.Update(clientModel);
                TempData["mensagem"] = "Cliente Alterado com Sucesso"; /*Exibe Mensagem de Sucesso na View*/

                return RedirectToAction("Index");
            }
            else
            {
                var listaRepresentantes = representanteRepository.FindAll();
                ViewBag.representantes = listaRepresentantes;
                return View(clientModel);

            }

        }

        
        public IActionResult Detales(int id)
        {
            var cliente = clienteRepository.FindById(id);

            return View(cliente);
        }

        

       
       



    }
}
