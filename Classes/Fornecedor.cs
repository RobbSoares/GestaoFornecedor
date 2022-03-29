namespace GestaoFornecedor;

public class Fornecedor
{
    public Fornecedor()
    {
        Contatos = new List<Contato>();
    }

    public int Id { get; set; }
    public bool IsRascunho { get; set; }
    public string Email { get; set; }
    public string Cnpj { get; set; }
    public string InscricaoEstadual { get; set; }
    public string InscricaoMunicipal { get; set; }
    public long DtCadastro { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public IList<Contato> Contatos { get; set; }
    public StatusServico Status { get; set; } = StatusServico.NaoIniciado;
    
    public void Salvar() { }
    public void Alterar() { }

    public IList<Fornecedor> consultar()
    {
        return new List<Fornecedor>();
    }
    public void Excluir() { }
    public void Inativar() { }
    public void Ativar() { }
    public void AddContato(Contato contato) { }
    public void ValidarCNPJ() { }
    public void ValidarListaFornecimento() { }
}