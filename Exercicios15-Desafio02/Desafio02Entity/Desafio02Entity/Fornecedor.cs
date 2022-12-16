using System;
using System.Collections.Generic;

namespace Desafio02Entity;

public partial class Fornecedor
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cnpj { get; set; }

    public string? Email { get; set; }

    public string? Endereco { get; set; }

    public virtual ICollection<Produto> Produtos { get; } = new List<Produto>();
}
