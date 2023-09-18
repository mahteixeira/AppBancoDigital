using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View.Pags.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixMenu : ContentPage
    {
        public PixMenu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("BancoDigital.Imagens.voltar-Rosa.png");

        }

        private async void btn_pagarPix_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.LerQRCode());
        }

        private async void btn_receberPIX_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.gerarQrCode());    
        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Inicio());
        }
    }
}