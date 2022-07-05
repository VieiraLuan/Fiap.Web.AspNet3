using Fiap.Web.AspNet3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {/*GET*/

            //Simulando Busca no BD

            var listaClientes = new List<ClientModel>();

            listaClientes.Add( new ClientModel
            {
                ClientId = 1,
                Name = "Flávio",
                Email = "fmoreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 2,
                Name = "Diogo",
                Email = "fmoreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 3,
                Name = "Luan",
                Email = "fmoreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 4,
                Name = "Thais",
                Email = "fmoreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 5,
                Name = "Fernando",
                Email = "fmoreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS1"
            });


            return View(listaClientes);
        }

        [HttpGet]
        public IActionResult NewClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewClient(ClientModel clientModel)
        {

            //Recuperar as informações do cliente digitado
            /*Passar por parametro a classe e um objeto para carregar*/



            //Cadastrar Banco (BD FAKE)
            TempData["mensagem"] = "Cliente cadastrado com sucesso";

            //Exibir uma tela de sucesso!
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
                var  clientModel = new ClientModel
                {
                    ClientId = 3,
                    Name = "Moreni",
                    Email = "moreni@gmail.com",
                    Birth = "14/04/2000",
                    Observation = "OBS3"
                };
            
            
            
            return View(clientModel);
        }

        [HttpPost]
        public IActionResult Edit(ClientModel clientModel)
        {

            //Recuperar as informações do cliente digitado
            /*Passar por parametro a classe e um objeto para carregar*/



            //Cadastrar Banco (BD FAKE)


            //Exibir uma tela de sucesso!
            return RedirectToAction("Index");
        }


        public IActionResult Detales(int id)
        {
            var clientModel = new ClientModel
            {
                ClientId = 3,
                Name = "Moreni",
                Email = "moreni@gmail.com",
                Birth = "14/04/2000",
                Observation = "OBS3"
            };



            return View(clientModel);
        }


     
    }
}
