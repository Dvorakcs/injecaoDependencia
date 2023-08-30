using injecaoDependencia.models;
using System.Runtime.CompilerServices;

namespace injecaoDependencia.DbMemory.Db
{
    internal class Dados<T>
    {
        private readonly Main main = new Main();
        public Dados()
        {
            
        }

        public object GetModel(Type type)
        {

            var result = main.Where(type);
            return result;
        }

    }
}
