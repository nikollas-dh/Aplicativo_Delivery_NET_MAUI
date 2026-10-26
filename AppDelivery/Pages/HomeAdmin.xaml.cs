

using AppDelivery.Models;

namespace AppDelivery.Pages;

public partial class HomeAdmin : ContentPage
{
    Services api = new Services();
    Usuario usuario;
    public HomeAdmin(Models.Usuario us)
	{
		InitializeComponent();
        usuario = us;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        CarregarDados();
    }

    private async void CarregarDados()
    {
        //var resumo = await api.ListarResumoAdmin();

        //lblPendentes.Text = resumo.pendentes.ToString();
        //lblEntregues.Text = resumo.entregues.ToString();
        //lblEmTransito.Text = resumo.emTransito.ToString();
        //lblCancelados.Text = resumo.cancelados.ToString();
    }
}