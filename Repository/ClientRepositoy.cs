using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Repository
{
    public class ClienteRepository
    {
        public DataContext context { get; set; }
        public ClienteRepository(DataContext ctx)
        {
            context = ctx;
        }
        public List<ClientModel> FindAll()
        {
            var listaclientes = context.Clients.Include(c => c.Representante).ToList();
            return listaclientes;
        }
        public ClientModel FindById(int id)
        {                   /*select * from clientes  inner join representantes   where    condicao*/
            var cliente = context.Clients.Include(c => c.Representante).SingleOrDefault(c => c.ClientId == id);


            return cliente;
        }
        public void Insert(ClientModel ClienteModel)
        {
            context.Clients.Add(ClienteModel);
            context.SaveChanges();
        }
        public void Update(ClientModel ClienteModel)
        {
            context.Clients.Update(ClienteModel);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            ClientModel clienteModel = new ClientModel();
            clienteModel.ClientId = 1;
            Delete(clienteModel);
        }
        public void Delete(ClientModel ClienteModel)
        {
            context.Clients.Remove(ClienteModel);
            context.SaveChanges();
        }
    }
}