using BancoDigital.Model;
using BancoDigital.Service;
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
    public partial class CadastroChave : ContentPage
    {
        public CadastroChave()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            canto.Source = ImageSource.FromResource("BancoDigital.Imagens.canto.png");

        }

        private async void btn_continuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string tipo_chave = pck_tipo.SelectedItem.ToString();
                string chave_pix = txt_chave.Text;

                await DataServiceChavePix.Adicionar(new ChavePix
                {
                    tipo = tipo_chave,
                    chave = chave_pix,
                    id_conta = App.DadosConta.id

                });

                await Navigation.PushAsync(new View.lista());


            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }           
        }
    }
}