using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class OS
    {
        public Fornecedor Fornecedor { get; set; }
        public long DtInicio { get; set; }
        public IList<Servico> Servicos { get; set; }
    }
}
