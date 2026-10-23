using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Entregador
{
    public int IdEntregador { get; set; }

    public int? IdUsuario { get; set; }

    public string? Placa { get; set; }

    public int? CapacidadeBolsa { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
