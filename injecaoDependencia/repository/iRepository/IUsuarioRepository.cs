using injecaoDependencia.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.repository.iRepository
{
    internal interface IUsuarioRepository
    {
        object Getall();
        UsuarioModel Get(int id);
        void Add(UsuarioModel model);
    }
}
