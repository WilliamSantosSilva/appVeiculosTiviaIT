using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Base
{
   public   interface ISearchable <T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> condition);
        T GetById(int id);
    }
}
