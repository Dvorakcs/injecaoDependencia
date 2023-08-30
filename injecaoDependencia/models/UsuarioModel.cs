using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.models
{
    internal class UsuarioModel
    {
        public int? id { get; set; }
        public string? nome { get; set; } = string.Empty;

        public UsuarioModel(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public UsuarioModel()
        {
            
        }
    }
}
