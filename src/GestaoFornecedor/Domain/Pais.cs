using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Pais
    {
        public string Descricao { get; set; }
        public IList<UF> UFs { get; set; }
    }
}
