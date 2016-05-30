using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Base
{
    public interface ICreatable <T> where T : class
    {
        void Insert(T _model);
    }
}
