using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Empresa
    {
        public IList<Fornecedor>? Fornecedores { get; set; }
        public TipoEmpresa TipoEmpresa { get; set; }
    }
}
