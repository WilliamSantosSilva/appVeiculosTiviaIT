using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Base
{
    public interface IUpdatable <T> where T : class
    {
        void Update(T _model);
    }
}
