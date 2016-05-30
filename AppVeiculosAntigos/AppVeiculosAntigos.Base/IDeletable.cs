using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Base
{
   public interface IDeletable <T> where T : class
    {
        void Delete(T _model);
    }
}
