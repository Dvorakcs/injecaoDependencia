using injecaoDependencia.models;
using injecaoDependencia.repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.services
{
    internal class UsuarioServices
    {
        public IUsuarioRepository UsuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
             UsuarioRepository = usuarioRepository;
        }

        public object get()
        {
            return UsuarioRepository.Getall();
        }

        public void add(UsuarioModel model)
        {
            if (model == null)
            {
                this.UsuarioRepository.Add(model);
            }
        }
    }
}
