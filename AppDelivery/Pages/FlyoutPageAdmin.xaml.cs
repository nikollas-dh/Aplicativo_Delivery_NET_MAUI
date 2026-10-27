namespace AppDelivery.Pages;

public partial class FlyoutPageAdmin : FlyoutPage
{
	public FlyoutPageAdmin(Models.Usuario us, string v)
	{
		InitializeComponent();
        Flyout = new Menu(us,v);
        Detail = new NavigationPage(new HomeAdmin(us));
    }

    
}