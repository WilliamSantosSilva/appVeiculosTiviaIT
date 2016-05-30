using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppVeiculosAntigos.DTO;

namespace AppVeiculosAntigos.Business
{
    public class Veiculo : Base.Singleton<Veiculo>,
        Base.ISearchable<DTO.Veiculo>,
        Base.ICreatable<DTO.Veiculo>,
        Base.IUpdatable<DTO.Veiculo>,
        Base.IDeletable<DTO.Veiculo>
    {
        protected Dal.Veiculo context;
        public Veiculo()
        {
            context = new Dal.Veiculo();
        }

        public void Delete(DTO.Veiculo _model)
        {
            context.Delete(_model);
        }

        public IEnumerable<DTO.Veiculo> Get(Expression<Func<DTO.Veiculo, bool>> condition)
        {
            return context.Get(condition);
        }

        public DTO.Veiculo GetById(int id)
        {
            return context.GetById(id);
        }

        public void Insert(DTO.Veiculo _model)
        {
            context.Insert(_model);
        }

        public void Update(DTO.Veiculo _model)
        {
            context.Update(_model);
        }
    }
}
