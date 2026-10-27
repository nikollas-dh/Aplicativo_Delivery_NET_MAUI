

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
        try
        {
            int idRestaurante = await api.ObterIdRestaurante(usuario.IdUsuario);
            var resumo = await api.ListarResumoAdmin(idRestaurante);

            lblPendentes.Text = resumo.GetProperty("pendentes").ToString();
            lblEntregues.Text = resumo.GetProperty("entregues").ToString();
            lblEmTransito.Text = resumo.GetProperty("emTransito").ToString();
            lblCancelados.Text = resumo.GetProperty("cancelados").ToString();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro de Conexão", $"Não foi possível carregar os dados: {ex.Message}", "OK");
        }
    }
}