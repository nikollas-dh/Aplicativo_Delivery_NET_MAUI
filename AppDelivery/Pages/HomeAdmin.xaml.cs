namespace AppDelivery.Pages;

public partial class HomeAdmin : ContentPage
{
	public HomeAdmin()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        CarregarDados();
    }

    private void CarregarDados()
    {
        
    }
}