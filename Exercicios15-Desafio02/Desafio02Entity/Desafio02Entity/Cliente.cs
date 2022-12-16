using System;
using System.Collections.Generic;

namespace Desafio02Entity;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cpf { get; set; }

    public string? Email { get; set; }

    public string? Endereco { get; set; }

    public DateTime DataNasc { get; set; }

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();


}
