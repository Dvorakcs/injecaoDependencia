using injecaoDependencia.models;
using injecaoDependencia.repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.repository
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        void IUsuarioRepository.Add(UsuarioModel model)
        {
            throw new NotImplementedException();
        }

        UsuarioModel IUsuarioRepository.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<UsuarioModel> IUsuarioRepository.Getall()
        {
            throw new NotImplementedException();
        }
    }
}
