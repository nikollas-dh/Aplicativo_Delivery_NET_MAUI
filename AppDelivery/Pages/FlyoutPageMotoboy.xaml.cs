using AppDelivery.Models;

namespace AppDelivery.Pages;

public partial class FlyoutPageMotoboy : FlyoutPage
{
    
    public FlyoutPageMotoboy(Models.Usuario us, string v)
	{
		InitializeComponent();
        Flyout = new Menu(us,v);
        Detail = new NavigationPage(new HomeEntregador(us, v));
	}

    
}