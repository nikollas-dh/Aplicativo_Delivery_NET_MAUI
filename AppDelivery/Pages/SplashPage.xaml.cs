using System.Runtime.CompilerServices;

namespace AppDelivery.Pages;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        
        await Task.Delay(5000);
        this.BackgroundColor = Color.FromRgb(255, 250,240);
        logo.Source = "logo.png";
        await Task.Delay(5000);
        
        Application.Current.MainPage = new NavigationPage (new LoginPage());
    }
}