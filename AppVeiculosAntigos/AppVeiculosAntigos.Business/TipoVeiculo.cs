using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppVeiculosAntigos.DTO;

namespace AppVeiculosAntigos.Business
{
    public class TipoVeiculo : 
        Base.Singleton<TipoVeiculo>
        ,Base.ISearchable<DTO.TipoVeiculo>
    {
        protected Dal.TipoVeiculo context;
        public TipoVeiculo()
        {
            context = new Dal.TipoVeiculo();
        }

        public IEnumerable<DTO.TipoVeiculo> Get(Expression<Func<DTO.TipoVeiculo, bool>> condition)
        {
            return context.Get(condition);
        }

        public DTO.TipoVeiculo GetById(int id)
        {
            return context.GetById(id);
        }
    }
}
