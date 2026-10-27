using AppDelivery.Models;

namespace AppDelivery.Pages;

public partial class Menu : ContentPage
{
	public Menu(Models.Usuario us)
	{
		InitializeComponent();
        CarregarDados(us);
	}

    private void CarregarDados(Usuario us)
    {
        lblNome.Text = us.Nome;
        
    }

    private void OnTelaPrincipalClicked(object sender, TappedEventArgs e)
    {

    }

    private void ListarPedidosClicked(object sender, TappedEventArgs e)
    {

    }

    private void ConfigClicked(object sender, TappedEventArgs e)
    {

    }

    private void SairClicked(object sender, TappedEventArgs e)
    {

    }
}