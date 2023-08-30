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
        private readonly T Obj;
        public object Model { get; set; }
        

        public SetModel(T setModel) {
            Obj = setModel;
            this.Model = _Contexto.GetModel(this.Obj.GetType());
        }
    }
}
