using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class Administrador
{
    public int IdAdministrador { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRestaurante { get; set; }

    public virtual Restaurante? IdRestauranteNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
