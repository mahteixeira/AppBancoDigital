using BancoDigital.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            canto2.Source = ImageSource.FromResource("BancoDigital.Imagens.canto2.png");

            List<ChavePix> arr_pix = App.DadosConta.lista_pix;

            lst_chaves.ItemsSource = arr_pix;

        }

        private async void btn_pagar_qr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.LerQRCode());  
        }

        private async void btn_pagar_chave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.Pagar.PagarComChave());
        }

        private void btn_pagar_copiaecola_Clicked(object sender, EventArgs e)
        {

        }

        private async void btn_receberr_qr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.gerarQrCode());
        }

        private async void btn_novaChave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.CadastroChave());
        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Inicio());
        }
    }
}