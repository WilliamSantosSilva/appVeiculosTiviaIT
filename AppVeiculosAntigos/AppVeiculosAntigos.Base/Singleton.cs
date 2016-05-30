using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeiculosAntigos.Base
{
    public class Singleton<T> where T : Singleton<T>, new()
    {
        private static T instance;
        public static T Instance()
        {
            if (instance == null)
                lock (typeof(T))
                    if (instance == null) instance = new T();

            return instance;
        }

        //private static C instanceContextBaseDB;
        //public static C instanceContextBaseDB()
        //{
        //    if (instance == null)
        //        lock (typeof(C))
        //            if (instance == null) instance = new C();

        //    return instance;
        //}
    }
}
