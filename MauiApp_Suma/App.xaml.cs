using Microsoft.Maui.Controls;

namespace MauiApp_Suma
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}

