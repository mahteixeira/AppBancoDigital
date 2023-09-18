using BancoDigital.View.Cadastro;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("BancoDigital.Imagens.voltar.png");
            btn_perfil.Source = ImageSource.FromResource("BancoDigital.Imagens.perfil.png");
            
            


            string[] resultsArray = explode(" ", App.DadosCorrentista.nome);
            string Nome = resultsArray[0];

            txt_correntista.Text = Nome;

            string Saldo = App.DadosConta.saldo.ToString("C");

            txt_saldo.Text = Saldo;

            
           
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.lista());
        }

        private void btn_perfil_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_extrato_Clicked(object sender, EventArgs e)
        {

        }

        private async void btn_pix_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Pags.Pix.PixMenu());

        }

        private async void btn_cartao_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new View.Pags.Cartoes.Cartoes());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btn_transacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}