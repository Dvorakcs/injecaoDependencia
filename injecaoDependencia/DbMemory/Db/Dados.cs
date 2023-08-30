using injecaoDependencia.models;

namespace injecaoDependencia.DbMemory.Db
{
    internal class Dados<T>
    {
        public List<object> Main = new List<object> {
             new  {

                        Usuario = new List<UsuarioModel>
                        {
                        new UsuarioModel(1,"teste"),
                        new UsuarioModel(2,"teste2"),
                        new UsuarioModel(3,"teste3"),
                        new UsuarioModel(4,"teste4"),
                        new UsuarioModel(5,"teste5"),
                        new UsuarioModel(6,"teste6"),
                         }
             }

        };

        public object GetModel(Type type)
        {
            var Model = Main.FirstOrDefault(x => x.GetType() == type);
            return Model;
        }

    }
}
