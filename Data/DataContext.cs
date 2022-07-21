using Microsoft.EntityFrameworkCore;

using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RepresentanteModel>Representantes { get; set; }
        

        public DbSet<FornecedorModel> Fornecedores{ get; set; }

        public DbSet<ClientModel> Clients { get; set; } 

        public DbSet<GerenteModel> Gerentes { get; set; }

        
    }
}
