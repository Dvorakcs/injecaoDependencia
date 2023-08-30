using injecaoDependencia.models;


namespace injecaoDependencia.DbMemory.Db
{
    internal class Main
    {

        List<object> main = new List<object>
        {
      
                    new UsuarioModel(1,"teste"),
                    new UsuarioModel(2,"teste2"),
                    new UsuarioModel(3,"teste3"),
                    new UsuarioModel(4,"teste4"),
                    new UsuarioModel(5,"teste5"),
                    new UsuarioModel(6,"teste6")         
        };



        public object Where(Type type)
        {
            return this.main.Where(x => x.Equals(type));
        }
    }
}
