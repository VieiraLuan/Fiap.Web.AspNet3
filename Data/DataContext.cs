using Microsoft.EntityFrameworkCore;

using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Data
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RepresentanteModel> Representantes { get; set; }
    }
}
