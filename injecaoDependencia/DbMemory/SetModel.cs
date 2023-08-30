using injecaoDependencia.DbMemory.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.DbMemory
{
    internal class SetModel<T>
    {
        private readonly Dados<T>  _Contexto = new Dados<T>();
        public T Model { get; set; }
        public object objReturn { get; set; }

        public SetModel(T model) {

            this.Model = model;
            this.objReturn = _Contexto.GetModel(Model.GetType());
        }
    }
}
