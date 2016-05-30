using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AppVeiculosAntigos.Business
{
    public class Fabricante : Base.Singleton<Fabricante>,
        Base.ISearchable<DTO.Fabricante>
    {
        protected Dal.Fabricante context;
        public Fabricante()
        {
            context = new Dal.Fabricante();
        }

        public IEnumerable<DTO.Fabricante> Get(Expression<Func<DTO.Fabricante, bool>> condition)
        {
            return context.Get(condition);
        }

        public DTO.Fabricante GetById(int id)
        {
            return context.GetById(id);
        }
    }
}
