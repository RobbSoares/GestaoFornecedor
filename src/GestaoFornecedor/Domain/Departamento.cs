namespace GestaoFornecedor.Domain
{
    public class Departamento
    {
        public Departamento(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }
    }
}
