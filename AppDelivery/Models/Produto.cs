using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Produto
{
    public int IdProduto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? IdRestaurante { get; set; }

    public virtual Restaurante? IdRestauranteNavigation { get; set; }

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
}
