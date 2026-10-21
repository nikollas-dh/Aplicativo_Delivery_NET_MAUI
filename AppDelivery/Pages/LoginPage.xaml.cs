namespace AppDelivery.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new FlyoutPageAdmin();
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