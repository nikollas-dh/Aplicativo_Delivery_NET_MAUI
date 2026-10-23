using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public DateTime? DataCadastro { get; set; }

    public virtual ICollection<Administrador> Administradors { get; set; } = new List<Administrador>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Entregador> Entregadors { get; set; } = new List<Entregador>();

    public virtual ICollection<RecuperarSenha> RecuperarSenhas { get; set; } = new List<RecuperarSenha>();
}
