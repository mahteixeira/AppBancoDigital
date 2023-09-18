using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Pags.Cartoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cartoes : ContentPage
    {
        public Cartoes()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("BancoDigital.Imagens.voltar-Rosa.png");

        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Inicio());
        }
    }
}