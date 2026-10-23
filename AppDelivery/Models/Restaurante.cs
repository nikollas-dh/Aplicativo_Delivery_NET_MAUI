using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Restaurante
{
    public int IdRestaurante { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Administrador> Administradors { get; set; } = new List<Administrador>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
