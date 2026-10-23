using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public int? IdUsuario { get; set; }

    public string? Endereco { get; set; }

    public string? Cep { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
