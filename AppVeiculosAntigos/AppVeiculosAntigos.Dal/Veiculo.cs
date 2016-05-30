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
    public class Veiculo : Base.BaseContext<VeiculosAntigosEntities>,
        ISearchable<DTO.Veiculo>,
        ICreatable<DTO.Veiculo>,
        IUpdatable<DTO.Veiculo>,
        IDeletable<DTO.Veiculo>
    {
        public Veiculo() : base(new VeiculosAntigosEntities())
        {
        }

        private IQueryable<DTO.Veiculo> ModelToDto()
        {
            var result = context.TbVeiculo.Select(x => new DTO.Veiculo
            {
                IdVeiculo = x.ID,
                Descricao = x.Descricao,
                AnoFabricacao = x.AnoFabricao,
                Modelo = x.Modelo
                //Fabricante = new DTO.Fabricante
                //{
                //    IdFabricante = x.TbFabricante.ID,
                //    Descricao = x.TbFabricante.Descricao
                //},
                //TipoVeiculo = new DTO.TipoVeiculo
                //{
                //    IdVeiculo = x.TbTipoDeVeiculo.ID,
                //    Descricao = x.TbTipoDeVeiculo.Descricao
                //}
            });

            return result;
        }

        private TbVeiculo DtoToModel(DTO.Veiculo _model)
        {
            var model = new TbVeiculo
            {
                ID = _model.IdVeiculo,
                Descricao = _model.Descricao,
                AnoFabricao = _model.AnoFabricacao,
                Modelo = _model.Modelo,
                TbFabricante = new TbFabricante
                {
                    ID = _model.Fabricante.IdFabricante,
                    Descricao = _model.Descricao
                },
                TbTipoDeVeiculo = new TbTipoDeVeiculo
                {
                    ID = _model.TipoVeiculo.IdVeiculo,
                    Descricao = _model.Descricao
                }
            };

            return model;
        }

        public void Delete(DTO.Veiculo _model)
        {
            var model = DtoToModel(_model);
            context.TbVeiculo.Remove(model);
        }

        public IEnumerable<DTO.Veiculo> Get(Expression<Func<DTO.Veiculo, bool>> condition)
        {
            var result = ModelToDto();

            if (condition != null)
            {
                result = result.Where(condition);
            }

            return result.ToList();
        }

        public DTO.Veiculo GetById(int id)
        {
            var result = ModelToDto().FirstOrDefault(x => x.IdVeiculo == id);

            return result;
        }

        public void Insert(DTO.Veiculo _model)
        {
            var model = DtoToModel(_model);

            context.TbVeiculo.Add(model);
        }

        public void Update(DTO.Veiculo _model)
        {
            var model = DtoToModel(_model);

            context.TbVeiculo.Attach(model);
            context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
