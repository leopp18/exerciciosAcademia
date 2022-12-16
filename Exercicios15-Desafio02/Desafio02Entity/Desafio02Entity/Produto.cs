using System;
using System.Collections.Generic;

namespace Desafio02Entity;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public decimal Valor { get; set; }

    public int FkFornecedor { get; set; }

    public virtual Fornecedor FkFornecedorNavigation { get; set; } = null!;

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();
}
