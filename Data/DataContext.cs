using Microsoft.EntityFrameworkCore;

using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Data
{
    public class DataContext : DbContext
    {


        public DbSet<RepresentanteModel>Representantes { get; set; }
        /*Propriedade*/

        public DbSet<FornecedorModel> Fornecedores{ get; set; }

        //public DbSet<ClientModel> Clients { get; set; } 

        public DbSet<GerenteModel> Gerentes { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {/*Construtor*/

        }
    }
}
