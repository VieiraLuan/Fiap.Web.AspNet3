using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class RepresentanteRepository
    {
        private readonly DataContext dataContext;

        public RepresentanteRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<RepresentanteModel> FindAll() {

           return dataContext.Representantes.ToList<RepresentanteModel>();

        }

        public RepresentanteModel FindById(int id) {
            return dataContext.Representantes.Find(id);
        }

        public List<RepresentanteModel> FindByName(string name)
        {
            return null;
        }

        public void Insert(RepresentanteModel representanteModel) {
            dataContext.Representantes.Add(representanteModel);
            //e
            dataContext.SaveChanges();
        }

        public void Update(RepresentanteModel representanteModel) {
            dataContext.Representantes.Update(representanteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int idRepresentante)
        {
            var representante = FindById(idRepresentante);
            Delete(representante);
        }
        public void Delete(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Remove(representanteModel);
            dataContext.SaveChanges();
        }

       


    }
}
