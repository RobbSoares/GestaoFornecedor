﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedor.Domain
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
