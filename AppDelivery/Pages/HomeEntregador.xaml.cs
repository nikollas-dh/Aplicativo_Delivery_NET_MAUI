

namespace AppDelivery.Pages;

public partial class HomeEntregador : ContentPage
{
    Services api = new Services();
    public HomeEntregador(Models.Usuario us, string v)
	{
		InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();


        var pedidos = await api.ListarPedidosEntregador();

        cvPedidos.ItemsSource = pedidos;
    }
}