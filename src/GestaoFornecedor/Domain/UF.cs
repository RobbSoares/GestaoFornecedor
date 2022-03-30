using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class UF
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public Pais Pais { get; set; }
        public IList<Cidade> Cidade { get; set; }
    }
}
