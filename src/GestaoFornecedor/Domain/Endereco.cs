using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public TipoLogradouro TipoLogradouro { get; set; }
        public Cidade Cidade { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }
}
