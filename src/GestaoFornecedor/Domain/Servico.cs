using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Servico
    {
        public int Id { get; set; }
        public OS OS { get; set; }
        public string Descricao { get; set; }
    }
}
