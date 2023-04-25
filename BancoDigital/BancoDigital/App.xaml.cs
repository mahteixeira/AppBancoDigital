using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.CadastroCorrentista());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
