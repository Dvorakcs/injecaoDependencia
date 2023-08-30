using injecaoDependencia.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.DbMemory
{
    internal class DbContextMemory
    {
        public SetModel<UsuarioModel> usuarios = new SetModel<UsuarioModel>(new UsuarioModel());
        public SetModel<CarrinhoModel> carrinhos = new SetModel<CarrinhoModel>(new CarrinhoModel());
        public DbContextMemory()
        {
            
        }
        
    }
}
