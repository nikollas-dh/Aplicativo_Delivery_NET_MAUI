using System;
using System.Collections.Generic;

namespace AppDelivery.Models;

public partial class RecuperarSenha
{
    public int IdRecuperacao { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdFrase { get; set; }

    public string RespostaSecreta { get; set; } = null!;

    public virtual FraseSecretum? IdFraseNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
