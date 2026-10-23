using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class StatusPedido
{
    public int IdStatus { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
