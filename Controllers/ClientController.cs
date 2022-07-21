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

            return View( new ClientModel());
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
        public IActionResult Edit(int id)//Verificar com o professor
        {
            var cliente = clienteRepository.FindById(id);
            var listaRepresentantes = representanteRepository.FindAll();
            ViewBag.representantes = listaRepresentantes;


            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(ClientModel clientModel)/*Passar por parametro a classe e um objeto para carregar*/
        {
            
            if (ModelState.IsValid) {
                //Editar Cliente no Banco 
                TempData["mensagem"] = "Cliente Alterado com Sucesso"; /*Exibe Mensagem de Sucesso na View*/
                //Exibir uma tela de sucesso!
                
                return RedirectToAction("Index");
            } else {
                //Recuperar as informações do cliente digitado na View de Cadastro
                // processo será o mesmo até o usuario Validar ou Cancelar a Alteração
                return View(clientModel);

            }
           
        }


        public IActionResult Detales(int id) //Verificar com o Professor
        {
            var clientModel = new ClientModel
            {
                ClientId = 3,
                Name = "Moreni",
                Email = "moreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS3"
            };



            return View(clientModel);
        }



    }
}
