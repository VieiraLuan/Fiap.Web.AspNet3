using Microsoft.EntityFrameworkCore;

using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Data
{
    public class DataContext : DbContext
    {


        public DbSet<RepresentanteModel>Representantes { get; set; }
        /*Propriedade*/

        //public DbSet<ClientModel> Clients { get; set; } 


        public DataContext(DbContextOptions options) : base(options)
        {/*Construtor*/

        }
    }
}
