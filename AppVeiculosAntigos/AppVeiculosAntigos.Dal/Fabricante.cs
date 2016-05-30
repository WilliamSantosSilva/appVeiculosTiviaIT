using AppVeiculosAntigos.Base;
using AppVeiculosAntigos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVeiculosAntigos.DTO;
using System.Linq.Expressions;

namespace AppVeiculosAntigos.Dal
{
    public class Fabricante : Base.BaseContext<VeiculosAntigosEntities>,
        ISearchable<DTO.Fabricante>
    {
        public Fabricante() : base(new VeiculosAntigosEntities())
        {
        }

        private IQueryable<DTO.Fabricante> ModelToDto()
        {
            var result = context.TbFabricante.Select(x => new DTO.Fabricante
            {
                IdFabricante = x.ID,
                Descricao = x.Descricao
            });

            return result;
        }

        public IEnumerable<DTO.Fabricante> Get(Expression<Func<DTO.Fabricante, bool>> condition)
        {
            var result = ModelToDto();

            if (condition!= null)
            {
                result = result.Where(condition);
            }

            return result;
        }

        public DTO.Fabricante GetById(int id)
        {
            var result = ModelToDto().FirstOrDefault(x => x.IdFabricante == id);            

            return result;
        }
    }
}
