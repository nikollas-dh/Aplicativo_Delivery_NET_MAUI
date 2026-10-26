namespace AppDelivery.Pages;

public partial class FlyoutPageAdmin : FlyoutPage
{
	public FlyoutPageAdmin(Models.Usuario us)
	{
		InitializeComponent();
        Flyout = new Menu(us);
        Detail = new NavigationPage(new HomeAdmin(us));
    }

    
}