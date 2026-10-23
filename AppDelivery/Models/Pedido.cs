using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEntregador { get; set; }

    public int? IdStatus { get; set; }

    public int? IdRestaurante { get; set; }

    public string? EnderecoEntrega { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Cep { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Entregador? IdEntregadorNavigation { get; set; }

    public virtual Restaurante? IdRestauranteNavigation { get; set; }

    public virtual StatusPedido? IdStatusNavigation { get; set; }

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
}
