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

        string tipo = dados.Value.GetProperty("tipoUsuario").GetString();

        //Application.Current.MainPage = tipo switch
        //{
        //    "Administrador" => new FlyoutPageAdmin(us, tipo),
        //    "Cliente" => new FlyoutPageUsuario(us, tipo),
        //    _ => new FlyoutPageMotoboy(us, tipo)
        //};

        if (tipo == "Administrador")
            Application.Current.MainPage = new FlyoutPageAdmin(us, "Administrador");

        else if (tipo == "Cliente")
            Application.Current.MainPage = new FlyoutPageUsuario(us, "Cliente");

        else if (tipo == "Entregador")
            Application.Current.MainPage = new FlyoutPageMotoboy(us, "Entregador");
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