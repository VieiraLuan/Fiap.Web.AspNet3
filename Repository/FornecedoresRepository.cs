using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class FornecedoresRepository
    {

        private readonly DataContext dtx;



        public FornecedoresRepository(DataContext dataContext)
        {
            this.dtx = dataContext;
        }

        public List<FornecedorModel> FindAll()
        {
            var fornecedor = dtx.Fornecedores.ToList();
            return fornecedor;
        }

        public FornecedorModel FindById(int id)
        {
            var fornecedor = dtx.Fornecedores.Find(id);


            return fornecedor;


        }

      /*  public FornecedorModel FindByName(FornecedorModel fornecedorModel) 
        {

            var fornecedor = dtx.Fornecedores.ToList();

            foreach (var f in fornecedor)
            {
               var fornEncontrado = FindById(f.FornecedorId);

                if(fornEncontrado != null)
                {
                    fornecedor = fornEncontrado;
                    return ;
                }
            }


        }*/

        /*Find By Name*/


        public void Insert(FornecedorModel fornecedorModel)
        {
            dtx.Fornecedores.Add(fornecedorModel);
            dtx.SaveChanges();
        }

        public void Update(FornecedorModel fornecedorModel) 
        {
           // var fornecedor = FindById(fornecedorModel.FornecedorId);
            dtx.Fornecedores.Update(fornecedorModel);
            dtx.SaveChanges();
        }

        public void Delete(int id)
        {
            var fornecedor = new FornecedorModel();
            fornecedor.FornecedorId = id;
            Delete(fornecedor);

        }

        public void Delete(FornecedorModel fornecedorModel)
        {
            dtx.Fornecedores.Remove(fornecedorModel);
            dtx.SaveChanges();

        }
    }
}
