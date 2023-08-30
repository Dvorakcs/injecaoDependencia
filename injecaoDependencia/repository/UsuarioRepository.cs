using injecaoDependencia.DbMemory;
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
        private readonly object usuario = new DbContextMemory().usuarios.Model;
        private readonly object carrinho = new DbContextMemory().carrinhos.Model;
        void IUsuarioRepository.Add(UsuarioModel model)
        {
            throw new NotImplementedException();
        }

        UsuarioModel IUsuarioRepository.Get(int id)
        {
            throw new NotImplementedException();
        }

        object IUsuarioRepository.Getall()
        {
            var Carrinho = carrinho;
            return usuario;
        }
    }
}
