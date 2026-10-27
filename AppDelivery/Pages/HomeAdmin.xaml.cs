

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
            // 1. Busca o ID do restaurante
            int idRestaurante = await api.ObterIdRestaurante(usuario.IdUsuario);

            // 2. Se o ID for 0 ou inválido, avisa o usuário e para por aqui (evita o erro 404 na API)
            if (idRestaurante <= 0)
            {
                await DisplayAlert("Aviso", "Este usuário não possui um restaurante válido vinculado.", "OK");
                return;
            }

            // 3. Busca o resumo com o ID correto
            var resumo = await api.ListarResumoAdmin(idRestaurante);

            // 4. Preenche os textos na tela
            lblPendentes.Text = resumo.pendentes.ToString();
            lblEntregues.Text = resumo.entregues.ToString();
            lblEmTransito.Text = resumo.emTransito.ToString();
            lblCancelados.Text = resumo.cancelados.ToString();
        }
        catch (Exception ex)
        {
            // Se houver qualquer falha de conexão, ela será exibida num alerta em vez de fechar o app
            await DisplayAlert("Erro de Conexão", $"Não foi possível carregar os dados: {ex.Message}", "OK");
        }
    }
}