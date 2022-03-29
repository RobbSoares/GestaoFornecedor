using GestaoFornecedor.Classes;

namespace GestaoFornecedor;

public class Contato : Pessoa
{
    public Contato(string email, Departamento departamento)
    {
        Email = email;
        Departamento = departamento;
    }

    public string Email { get; set; }
    public Departamento Departamento { get; set; }
}