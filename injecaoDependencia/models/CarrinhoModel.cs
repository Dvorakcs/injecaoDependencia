using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace injecaoDependencia.models
{
    internal class CarrinhoModel
    {
        public int id { get; set; }
        public List<object> Itens { get; set; }


        public CarrinhoModel()
        {
            Itens = new List<object>();
        }
    }
}
