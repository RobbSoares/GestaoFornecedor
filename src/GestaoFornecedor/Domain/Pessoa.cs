using System.Collections.Generic;

namespace GestaoFornecedor.Domain
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public IList<Usuario>? Usuarios { get; set; }
    }

}

