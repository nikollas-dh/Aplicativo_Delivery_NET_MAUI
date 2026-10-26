using AppDelivery.Models;

namespace AppDelivery.Pages;

public partial class LoginPage : ContentPage
{
    Services api = new Services();

    public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Usuario us = new Usuario
        {
            Email = txtEmail.Text,
            Senha = txtSenha.Text
        };

        var dados = await api.Login(us);

        if (dados == null)
        {
            await DisplayAlert("Erro", "Login inválido!", "OK");
            return;
        }

        us.IdUsuario = dados.Value.GetProperty("idUsuario").GetInt32();
        us.Nome = dados.Value.GetProperty("nome").GetString()!;
        us.Email = dados.Value.GetProperty("email").GetString()!;

        string tipo = dados.Value.GetProperty("tipoUsuario").GetString()!;

        if (tipo == "Administrador")
            await Navigation.PushAsync(new FlyoutPageAdmin(us));

        else if (tipo == "Cliente")
            await Navigation.PushAsync(new FlyoutPageUsuario(us));

        else if (tipo == "Entregador")
            await Navigation.PushAsync(new FlyoutPageMotoboy(us));
    }



    private void CriarContaClick(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new CadastroPage());
    }

    private void EsqueciSenha_Click(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new EsqueciSenhaPage());

    }
}