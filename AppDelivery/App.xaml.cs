using AppDelivery.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace AppDelivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new SplashPage());
        }
    }
}