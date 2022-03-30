using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Status
    {
        public string ATIVO { get; set; } = "ATIVO";
        public string RASCUNHO { get; set; } = "RASCUNHO";
        public string INATIVO { get; set; } = "INATIVO";
    }
}
