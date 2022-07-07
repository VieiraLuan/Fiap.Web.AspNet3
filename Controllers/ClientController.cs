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
            //Carregar Clientes

            var listaClientes = new List<ClientModel>();

            listaClientes.Add(new ClientModel
            {
                ClientId = 1,
                Name = "Flávio",
                Email = "fmoreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 2,
                Name = "Diogo",
                Email = "fmoreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 3,
                Name = "Luan",
                Email = "fmoreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 4,
                Name = "Thais",
                Email = "fmoreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS1"
            });

            listaClientes.Add(new ClientModel
            {
                ClientId = 5,
                Name = "Fernando",
                Email = "fmoreni@gmail.com",
                Birth = DateTime.Now,
                Observation = "OBS1"
            });

            //ViewBag.MessageObs = "Mensagem de Teste da Obs";
            //TempData["MessageTemp"] = "Mensagem temporária";

            return View(listaClientes);/*Manda para a View esse Objeto*/
        }/*Carregar Lista de Clientes*/

       
        public IActionResult NewClient()
        {
            return View();
        } /*Ir para a Pagina de Cadastro de um Novo Cliente*/

        [HttpPost]
        public IActionResult NewClient(ClientModel clientModel)/*Passar o Model desse Objeto*/
        { /*View retorna Model Preenchido*/
            if (ModelState.IsValid) /*Valida se tem algum dado faltando no Model*/
            {

                //Cadastrar Banco (BD FAKE)
                TempData["mensagem"] = "Cliente cadastrado com sucesso";/*Retorna Mensagem de Sucesso na View*/

                //Exibir uma View de sucesso! Com a Mensagem acima
                return RedirectToAction("Index");
            }
            else
            {
                //Recuperar as informações do cliente digitado na View de Cadastro
                // processo será o mesmo até o usuario Validar ou Cancelar a Alteração
                return View(clientModel);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)//Verificar com o professor
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
