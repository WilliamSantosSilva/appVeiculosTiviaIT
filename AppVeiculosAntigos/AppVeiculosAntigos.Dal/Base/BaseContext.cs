using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Dal.Base
{
   public class BaseContext <T> where T : DbContext
    {
        protected T context;
        public BaseContext(T _context)
        {
            this.context = _context;
        }

        void Dispose()
        {
            this.context.Dispose();
        }

        public virtual void SaveChanges()
        {
            this.context.SaveChanges();
        }         
    }
}
