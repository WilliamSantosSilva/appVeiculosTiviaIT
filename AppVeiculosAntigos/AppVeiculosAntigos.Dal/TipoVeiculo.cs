using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AppVeiculosAntigos.Base;
using AppVeiculosAntigos.DTO;
using AppVeiculosAntigos.Entities;

namespace AppVeiculosAntigos.Dal
{
    public class TipoVeiculo :
        Base.BaseContext<VeiculosAntigosEntities>,
        ISearchable<DTO.TipoVeiculo>
    {
        public TipoVeiculo() : base(new VeiculosAntigosEntities())
        {
        }

        public IQueryable<DTO.TipoVeiculo> ModelToDto()
        {
            var result = context.TbTipoDeVeiculo.Select(x => new DTO.TipoVeiculo
            {
                IdVeiculo = x.ID,
                Descricao = x.Descricao
            });

            return result;
        }

        public IEnumerable<DTO.TipoVeiculo> Get(Expression<Func<DTO.TipoVeiculo, bool>> condition)
        {
            var result = ModelToDto();

            if (condition != null)
            {
                result = result.Where(condition);
            }

            return result.ToList();
        }

        public DTO.TipoVeiculo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
