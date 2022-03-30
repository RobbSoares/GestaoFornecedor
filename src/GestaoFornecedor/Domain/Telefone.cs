namespace GestaoFornecedor.Domain
{
    public class Telefone
    {
        public string DDD { get; set; }
        public string Numero { get; set; }
        public string DDI { get; set; }
        public TipoTelefone TipoTelefone { get; set;  }
    }
}
